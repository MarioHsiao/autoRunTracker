/** Generic interface to the RapidXML parser
 *
 *  @file
 *
 *  @date 11/9/15
 *  @version 1.0
 *  @copyright Illumina Use Only
 */

#pragma once

#include <interop/external/rapidxml.hpp>
#include <interop/external/rapidxml_utils.hpp>
#include <interop/external/rapidxml_print.hpp>
#include "interop/util/assert.h"
#include "interop/util/xml_exceptions.h"
#include "interop/util/exception.h"

namespace illumina { namespace interop { namespace xml
{

    /** XML node pointer type */
    typedef rapidxml::xml_node<> *xml_node_ptr;
    /** XML attribute pointer type */
    typedef rapidxml::xml_attribute<> *xml_attr_ptr;

    /** XML document wrapper */
    class xml_document
    {
    public:
        /** Constructor */
        xml_document()
        {
            rapidxml::xml_node<>* decl = m_doc.allocate_node(rapidxml::node_declaration);
            m_backing.reserve(50);
            decl->append_attribute(m_doc.allocate_attribute("version", "1.0"));
            m_doc.append_node(decl);
        }
        /** Add a node to the document with a given parent
         *
         * @param parent parent of the node
         * @param name name of the node
         * @return pointer to new node
         */
        xml_node_ptr add_node(xml_node_ptr parent, const char* name)
        {
            rapidxml::xml_node<>* child = m_doc.allocate_node(rapidxml::node_element, name);
            parent->append_node(child);
            return child;
        }
        /** Add a node to the document root
         *
         * @param name name of the node
         * @return pointer to new node
         */
        xml_node_ptr add_node(const char* name)
        {
            return add_node(&m_doc, name);
        }
        /** Add a node to the document with a given parent
         *
         * @param parent parent of the node
         * @param name name of the node
         * @param val value of the node
         * @return pointer to new node
         */
        template<typename T>
        xml_node_ptr add_node(xml_node_ptr parent, const char* name, const T& val)
        {
            m_backing.push_back(util::lexical_cast<std::string>(val));
            rapidxml::xml_node<>* child = m_doc.allocate_node(rapidxml::node_element, name, m_backing.back().c_str());
            parent->append_node(child);
            return child;
        }
        /** Add an attribute to the given parent node
         *
         * @param parent parent of the node
         * @param name name of the node
         * @param val value of the node
         * @return pointer to new node
         */
        template<typename T>
        void add_attribute(xml_node_ptr parent, const char* name, const T& val)
        {
            m_backing.push_back(util::lexical_cast<std::string>(val));
            parent->append_attribute(m_doc.allocate_attribute(name, m_backing.back().c_str()));
        }
        /** Write an XML document to the output stream
         *
         * @param out output stream
         * @param doc XML document
         * @return output stream
         */
        friend std::ostream& operator<<(std::ostream& out, const xml_document& doc)
        {
            out << doc.m_doc;
            return out;
        }

    private:
        rapidxml::xml_document<> m_doc;
        std::vector<std::string> m_backing;
    };
    /** Check if the xml node matches the target, and, if so, set the value
     *
     * @param p_node current node
     * @param target target string
     * @param val destination value
     * @param default_val default value if the tag is not found
     * @return true if the target was found
     */
    template<class T>
    bool set_data_with_default(xml_node_ptr p_node, const char* target, T &val, const T default_val)
    {
        INTEROP_ASSERT(p_node != 0);
        p_node = p_node->first_node(target);
        if (p_node == 0)
        {
            val = default_val;
            return false;
        }
        val = util::lexical_cast<T>(p_node->value());
        return true;
    }

    /** Find the target node and set the value
     *
     * @param p_node current node
     * @param target target string
     * @param val destination value
     * @return true if the target was found
     */
    template<class T>
    void set_data_for_target(xml_node_ptr p_node, const std::string &target, T &val)
    {
        if (p_node == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find parent");
        p_node = p_node->first_node(target.c_str());
        if (p_node == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find node: " << target);
        val = util::lexical_cast<T>(p_node->value());
    }

    /** Find the target node and set the value
     *
     * @param p_node current node
     * @param target target string
     * @param val destination value
     * @param default_val default value if the tag is not found
     * @return true if the target was found
     */
    template<class T>
    void set_data_for_target(xml_node_ptr p_node, const std::string &target, T &val, const T default_val)
    {
        if (p_node == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find parent for target: " << target);
        p_node = p_node->first_node(target.c_str());
        if (p_node == 0) val = default_val;
        else val = util::lexical_cast<T>(p_node->value());
    }

    /** Check if the xml node matches the target, and, if so, set the value
     *
     * @param p_node current node
     * @param target target string
     * @param val destination value
     * @return true if the target was found
     */
    template<class T>
    bool set_data(xml_node_ptr p_node, const std::string &target, T &val)
    {
        if (p_node == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find node: " << target);
        if (p_node->name() == target)
        {
            val = util::lexical_cast<T>(p_node->value());
            return true;
        }
        return false;
    }

    /** Convert the value of the node to the destination type
     *
     * @param p_attr current node
     * @param val destination value
     */
    template<class T>
    void set_data(xml_node_ptr p_attr, T &val)
    {
        if (p_attr == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find node");
        val = util::lexical_cast<T>(p_attr->value());
    }

    /** Check if the xml attributes matches the target, and, if so, set the value
     *
     * @param p_attr current attribute
     * @param target target string
     * @param val destination value
     * @return true if the target was found
     */
    template<class T>
    bool set_data(xml_attr_ptr p_attr, const std::string &target, T &val)
    {
        if (p_attr == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find attribute: " << target);
        if (p_attr->name() == target)
        {
            std::string tmp = p_attr->value();
            if(tmp[0] == '\"' && tmp[tmp.length()-1] == '\"')
            {
                tmp = tmp.substr(1, tmp.length()-1);
            }
            val = util::lexical_cast<T>(tmp);
            return true;
        }
        return false;
    }

    /** Convert the value of the attribute to the destination type
     *
     * @param p_node current node
     * @param target target string
     * @param val destination value
     */
    template<class T>
    void set_data_from_attribute(xml_node_ptr p_node, const char* target, T &val)
    {
        INTEROP_ASSERT(p_node != 0);
        xml_attr_ptr p_attr = p_node->first_attribute(target);
        if (p_attr == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find attribute: " << target);
        std::string tmp = p_attr->value();
        if(tmp[0] == '\"' && tmp[tmp.length()-1] == '\"')
        {
            tmp = tmp.substr(1, tmp.length()-1);
        }
        val = util::lexical_cast<T>(tmp);
    }

    /** Check if the xml node matches the target, and, if so, save the children to the vector
     *
     * @param p_node current node
     * @param target target string
     * @param child child node name
     * @param val destination vector
     * @return true if the target was found
     */
    template<class T>
    bool set_data(xml_node_ptr p_node, const std::string &target, const std::string &child, std::vector<T> &val)
    {
        if (p_node == 0)
            INTEROP_THROW(missing_xml_element_exception, "Cannot find node: " << target);
        if (p_node->name() == target)
        {
            val.clear();
            for (rapidxml::xml_node<> *p_name = p_node->first_node(); p_name; p_name = p_name->next_sibling())
            {
                if (p_name->name() != child) continue;
                val.push_back(util::lexical_cast<T>(p_name->value()));
            }
            return true;
        }
        return false;
    }

}}}


