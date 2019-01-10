// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.1.34438 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>ChkLst.Core</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>True</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace ChkLst.Core
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/XCheckList.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/XCheckList.xsd", IsNullable = false)]
    public partial class XCheckList
    {

        private XHeader headerField;

        private XItem mainItemField;

        private string versionField;

        /// <summary>
        /// XCheckList class constructor
        /// </summary>
        public XCheckList()
        {
            this.mainItemField = new XItem();
            this.headerField = new XHeader();
        }

        /// <summary>
        /// Заголовок
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public virtual XHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <summary>
        /// Главная задача
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public virtual XItem MainItem
        {
            get
            {
                return this.mainItemField;
            }
            set
            {
                this.mainItemField = value;
            }
        }

        /// <summary>
        /// Версия
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this XCheckList object
        /// </summary>
        public virtual XCheckList Clone()
        {
            return ((XCheckList)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/XCheckList.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/XCheckList.xsd", IsNullable = true)]
    public partial class XHeader
    {

        private string workItemField;

        private System.DateTime creationDateField;

        private string createdByField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string WorkItem
        {
            get
            {
                return this.workItemField;
            }
            set
            {
                this.workItemField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this XHeader object
        /// </summary>
        public virtual XHeader Clone()
        {
            return ((XHeader)(this.MemberwiseClone()));
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/XCheckList.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/XCheckList.xsd", IsNullable = true)]
    public partial class XItem
    {

        private List<XItem> itemField;

        private string nameField;

        private bool doneField;

        private string timeCostField;

        /// <summary>
        /// XItem class constructor
        /// </summary>
        public XItem()
        {
            this.itemField = new List<XItem>();
        }

        [System.Xml.Serialization.XmlElementAttribute("Item", Order = 0)]
        public virtual List<XItem> Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual bool Done
        {
            get
            {
                return this.doneField;
            }
            set
            {
                this.doneField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public virtual string TimeCost
        {
            get
            {
                return this.timeCostField;
            }
            set
            {
                this.timeCostField = value;
            }
        }

        #region Clone method
        /// <summary>
        /// Create a clone of this XItem object
        /// </summary>
        public virtual XItem Clone()
        {
            return ((XItem)(this.MemberwiseClone()));
        }
        #endregion
    }
}