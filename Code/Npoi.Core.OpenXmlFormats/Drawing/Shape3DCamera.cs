// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Npoi.Core.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Xml;
    using Npoi.Core.OpenXml4Net.Util;
    using System.IO;


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_Camera
    {

        private CT_SphereCoords rotField;

        private ST_PresetCameraType prstField;

        private int fovField;

        private bool fovFieldSpecified;

        private int zoomField;
        public static CT_Camera Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Camera ctObj = new CT_Camera();
            if (node.Attribute("prst") != null)
                ctObj.prst = (ST_PresetCameraType)Enum.Parse(typeof(ST_PresetCameraType), node.Attribute("prst").Value);
            ctObj.fov = XmlHelper.ReadInt(node.Attribute("fov"));
            ctObj.zoom = XmlHelper.ReadInt(node.Attribute("zoom"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "rot")
                    ctObj.rot = CT_SphereCoords.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<a:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
            XmlHelper.WriteAttribute(sw, "fov", this.fov);
            XmlHelper.WriteAttribute(sw, "zoom", this.zoom);
            sw.Write(">");
            if (this.rot != null)
                this.rot.Write(sw, "rot");
            sw.Write(string.Format("</a:{0}>", nodeName));
        }

        public CT_Camera()
        {
            this.rotField = new CT_SphereCoords();
            this.zoomField = 100000;
        }

        [XmlElement(Order = 0)]
        public CT_SphereCoords rot
        {
            get
            {
                return this.rotField;
            }
            set
            {
                this.rotField = value;
            }
        }

        [XmlAttribute]
        public ST_PresetCameraType prst
        {
            get
            {
                return this.prstField;
            }
            set
            {
                this.prstField = value;
            }
        }

        [XmlAttribute]
        public int fov
        {
            get
            {
                return this.fovField;
            }
            set
            {
                this.fovField = value;
            }
        }

        [XmlIgnore]
        public bool fovSpecified
        {
            get
            {
                return this.fovFieldSpecified;
            }
            set
            {
                this.fovFieldSpecified = value;
            }
        }

        [XmlAttribute]
        [DefaultValue(100000)]
        public int zoom
        {
            get
            {
                return this.zoomField;
            }
            set
            {
                this.zoomField = value;
            }
        }
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_PresetCameraType
    {

        /// <remarks/>
        legacyObliqueTopLeft,

        /// <remarks/>
        legacyObliqueTop,

        /// <remarks/>
        legacyObliqueTopRight,

        /// <remarks/>
        legacyObliqueLeft,

        /// <remarks/>
        legacyObliqueFront,

        /// <remarks/>
        legacyObliqueRight,

        /// <remarks/>
        legacyObliqueBottomLeft,

        /// <remarks/>
        legacyObliqueBottom,

        /// <remarks/>
        legacyObliqueBottomRight,

        /// <remarks/>
        legacyPerspectiveTopLeft,

        /// <remarks/>
        legacyPerspectiveTop,

        /// <remarks/>
        legacyPerspectiveTopRight,

        /// <remarks/>
        legacyPerspectiveLeft,

        /// <remarks/>
        legacyPerspectiveFront,

        /// <remarks/>
        legacyPerspectiveRight,

        /// <remarks/>
        legacyPerspectiveBottomLeft,

        /// <remarks/>
        legacyPerspectiveBottom,

        /// <remarks/>
        legacyPerspectiveBottomRight,

        /// <remarks/>
        orthographicFront,

        /// <remarks/>
        isometricTopUp,

        /// <remarks/>
        isometricTopDown,

        /// <remarks/>
        isometricBottomUp,

        /// <remarks/>
        isometricBottomDown,

        /// <remarks/>
        isometricLeftUp,

        /// <remarks/>
        isometricLeftDown,

        /// <remarks/>
        isometricRightUp,

        /// <remarks/>
        isometricRightDown,

        /// <remarks/>
        isometricOffAxis1Left,

        /// <remarks/>
        isometricOffAxis1Right,

        /// <remarks/>
        isometricOffAxis1Top,

        /// <remarks/>
        isometricOffAxis2Left,

        /// <remarks/>
        isometricOffAxis2Right,

        /// <remarks/>
        isometricOffAxis2Top,

        /// <remarks/>
        isometricOffAxis3Left,

        /// <remarks/>
        isometricOffAxis3Right,

        /// <remarks/>
        isometricOffAxis3Bottom,

        /// <remarks/>
        isometricOffAxis4Left,

        /// <remarks/>
        isometricOffAxis4Right,

        /// <remarks/>
        isometricOffAxis4Bottom,

        /// <remarks/>
        obliqueTopLeft,

        /// <remarks/>
        obliqueTop,

        /// <remarks/>
        obliqueTopRight,

        /// <remarks/>
        obliqueLeft,

        /// <remarks/>
        obliqueRight,

        /// <remarks/>
        obliqueBottomLeft,

        /// <remarks/>
        obliqueBottom,

        /// <remarks/>
        obliqueBottomRight,

        /// <remarks/>
        perspectiveFront,

        /// <remarks/>
        perspectiveLeft,

        /// <remarks/>
        perspectiveRight,

        /// <remarks/>
        perspectiveAbove,

        /// <remarks/>
        perspectiveBelow,

        /// <remarks/>
        perspectiveAboveLeftFacing,

        /// <remarks/>
        perspectiveAboveRightFacing,

        /// <remarks/>
        perspectiveContrastingLeftFacing,

        /// <remarks/>
        perspectiveContrastingRightFacing,

        /// <remarks/>
        perspectiveHeroicLeftFacing,

        /// <remarks/>
        perspectiveHeroicRightFacing,

        /// <remarks/>
        perspectiveHeroicExtremeLeftFacing,

        /// <remarks/>
        perspectiveHeroicExtremeRightFacing,

        /// <remarks/>
        perspectiveRelaxed,

        /// <remarks/>
        perspectiveRelaxedModerately,
    }
}
