// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using Npoi.Core.OpenXml4Net.Util;
using Npoi.Core.OpenXml4Net.OPC;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{



	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_FileVersion
	{

		private string appNameField;

		private string lastEditedField;

		private string lowestEditedField;

		private string rupBuildField;

		private string codeNameField;
		public static CT_FileVersion Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_FileVersion ctObj = new CT_FileVersion();
			ctObj.appName = XmlHelper.ReadString(node.Attribute("appName"));
			ctObj.lastEdited = XmlHelper.ReadString(node.Attribute("lastEdited"));
			ctObj.lowestEdited = XmlHelper.ReadString(node.Attribute("lowestEdited"));
			ctObj.rupBuild = XmlHelper.ReadString(node.Attribute("rupBuild"));
			ctObj.codeName = XmlHelper.ReadString(node.Attribute("codeName"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "appName", this.appName);
			XmlHelper.WriteAttribute(sw, "lastEdited", this.lastEdited);
			XmlHelper.WriteAttribute(sw, "lowestEdited", this.lowestEdited);
			XmlHelper.WriteAttribute(sw, "rupBuild", this.rupBuild);
			XmlHelper.WriteAttribute(sw, "codeName", this.codeName);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		[XmlAttribute]
		public string appName
		{
			get
			{
				return this.appNameField;
			}
			set
			{
				this.appNameField = value;
			}
		}
		[XmlAttribute]
		public string lastEdited
		{
			get
			{
				return this.lastEditedField;
			}
			set
			{
				this.lastEditedField = value;
			}
		}
		[XmlAttribute]
		public string lowestEdited
		{
			get
			{
				return this.lowestEditedField;
			}
			set
			{
				this.lowestEditedField = value;
			}
		}
		[XmlAttribute]
		public string rupBuild
		{
			get
			{
				return this.rupBuildField;
			}
			set
			{
				this.rupBuildField = value;
			}
		}
		[XmlAttribute]
		public string codeName
		{
			get
			{
				return this.codeNameField;
			}
			set
			{
				this.codeNameField = value;
			}
		}
	}



	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_FileRecoveryPr
	{

		private bool autoRecoverField;

		private bool crashSaveField;

		private bool dataExtractLoadField;

		private bool repairLoadField;
		public static CT_FileRecoveryPr Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_FileRecoveryPr ctObj = new CT_FileRecoveryPr();
			ctObj.autoRecover = XmlHelper.ReadBool(node.Attribute("autoRecover"));
			ctObj.crashSave = XmlHelper.ReadBool(node.Attribute("crashSave"));
			ctObj.dataExtractLoad = XmlHelper.ReadBool(node.Attribute("dataExtractLoad"));
			ctObj.repairLoad = XmlHelper.ReadBool(node.Attribute("repairLoad"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "autoRecover", this.autoRecover);
			XmlHelper.WriteAttribute(sw, "crashSave", this.crashSave);
			XmlHelper.WriteAttribute(sw, "dataExtractLoad", this.dataExtractLoad);
			XmlHelper.WriteAttribute(sw, "repairLoad", this.repairLoad);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		public CT_FileRecoveryPr()
		{
			this.autoRecoverField = true;
			this.crashSaveField = false;
			this.dataExtractLoadField = false;
			this.repairLoadField = false;
		}

		[DefaultValue(true)]
		public bool autoRecover
		{
			get
			{
				return this.autoRecoverField;
			}
			set
			{
				this.autoRecoverField = value;
			}
		}

		[DefaultValue(false)]
		public bool crashSave
		{
			get
			{
				return this.crashSaveField;
			}
			set
			{
				this.crashSaveField = value;
			}
		}

		[DefaultValue(false)]
		public bool dataExtractLoad
		{
			get
			{
				return this.dataExtractLoadField;
			}
			set
			{
				this.dataExtractLoadField = value;
			}
		}

		[DefaultValue(false)]
		public bool repairLoad
		{
			get
			{
				return this.repairLoadField;
			}
			set
			{
				this.repairLoadField = value;
			}
		}
	}


	public enum ST_Objects
	{


		all,


		placeholders,


		none,
	}

	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_OleSize
	{
		public static CT_OleSize Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_OleSize ctObj = new CT_OleSize();
			ctObj.@ref = XmlHelper.ReadString(node.Attribute("ref"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		private string refField;
		[XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}
	}

	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_CalcPr
	{

		private uint calcIdField;

		private bool calcIdFieldSpecified;

		private ST_CalcMode calcModeField;

		private bool fullCalcOnLoadField;

		private ST_RefMode refModeField;

		private bool iterateField;

		private uint iterateCountField;

		private double iterateDeltaField;

		private bool fullPrecisionField;

		private bool calcCompletedField;

		private bool calcOnSaveField;

		private bool concurrentCalcField;

		private uint concurrentManualCountField;

		private bool concurrentManualCountFieldSpecified;

		private bool forceFullCalcField;

		private bool forceFullCalcFieldSpecified;
		public static CT_CalcPr Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_CalcPr ctObj = new CT_CalcPr();
			ctObj.calcId = XmlHelper.ReadUInt(node.Attribute("calcId"));
			if (node.Attribute("calcMode") != null)
				ctObj.calcMode = (ST_CalcMode)Enum.Parse(typeof(ST_CalcMode), node.Attribute("calcMode").Value);
			ctObj.fullCalcOnLoad = XmlHelper.ReadBool(node.Attribute("fullCalcOnLoad"));
			if (node.Attribute("refMode") != null)
				ctObj.refMode = (ST_RefMode)Enum.Parse(typeof(ST_RefMode), node.Attribute("refMode").Value);
			ctObj.iterate = XmlHelper.ReadBool(node.Attribute("iterate"));
			ctObj.iterateCount = XmlHelper.ReadUInt(node.Attribute("iterateCount"));
			ctObj.iterateDelta = XmlHelper.ReadDouble(node.Attribute("iterateDelta"));
			ctObj.fullPrecision = XmlHelper.ReadBool(node.Attribute("fullPrecision"), true);
			ctObj.calcCompleted = XmlHelper.ReadBool(node.Attribute("calcCompleted"));
			ctObj.calcOnSave = XmlHelper.ReadBool(node.Attribute("calcOnSave"));
			ctObj.concurrentCalc = XmlHelper.ReadBool(node.Attribute("concurrentCalc"));
			ctObj.concurrentManualCount = XmlHelper.ReadUInt(node.Attribute("concurrentManualCount"));
			ctObj.forceFullCalc = XmlHelper.ReadBool(node.Attribute("forceFullCalc"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "calcId", this.calcId);
			if (calcMode == ST_CalcMode.auto)
				XmlHelper.WriteAttribute(sw, "calcMode", this.calcMode.ToString());
			XmlHelper.WriteAttribute(sw, "fullCalcOnLoad", this.fullCalcOnLoad);
			XmlHelper.WriteAttribute(sw, "refMode", this.refMode.ToString());
			XmlHelper.WriteAttribute(sw, "iterate", this.iterate);
			XmlHelper.WriteAttribute(sw, "iterateCount", this.iterateCount);
			XmlHelper.WriteAttribute(sw, "iterateDelta", this.iterateDelta);
			XmlHelper.WriteAttribute(sw, "fullPrecision", this.fullPrecision);
			XmlHelper.WriteAttribute(sw, "calcCompleted", this.calcCompleted);
			XmlHelper.WriteAttribute(sw, "calcOnSave", this.calcOnSave);
			XmlHelper.WriteAttribute(sw, "concurrentCalc", this.concurrentCalc);
			XmlHelper.WriteAttribute(sw, "concurrentManualCount", this.concurrentManualCount);
			XmlHelper.WriteAttribute(sw, "forceFullCalc", this.forceFullCalc);
			sw.Write("/>");
		}

		public CT_CalcPr()
		{
			this.calcModeField = ST_CalcMode.auto;
			this.fullCalcOnLoadField = false;
			this.refModeField = ST_RefMode.A1;
			this.iterateField = false;
			this.iterateCountField = ((uint)(100));
			this.iterateDeltaField = 0.001D;
			this.fullPrecisionField = true;
			this.calcCompletedField = true;
			this.calcOnSaveField = true;
			this.concurrentCalcField = true;
		}
		[XmlAttribute]
		public uint calcId
		{
			get
			{
				return this.calcIdField;
			}
			set
			{
				this.calcIdField = value;
			}
		}

		[XmlIgnore]
		public bool calcIdSpecified
		{
			get
			{
				return this.calcIdFieldSpecified;
			}
			set
			{
				this.calcIdFieldSpecified = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(ST_CalcMode.auto)]
		public ST_CalcMode calcMode
		{
			get
			{
				return this.calcModeField;
			}
			set
			{
				this.calcModeField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool fullCalcOnLoad
		{
			get
			{
				return this.fullCalcOnLoadField;
			}
			set
			{
				this.fullCalcOnLoadField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(ST_RefMode.A1)]
		public ST_RefMode refMode
		{
			get
			{
				return this.refModeField;
			}
			set
			{
				this.refModeField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool iterate
		{
			get
			{
				return this.iterateField;
			}
			set
			{
				this.iterateField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(typeof(uint), "100")]
		public uint iterateCount
		{
			get
			{
				return this.iterateCountField;
			}
			set
			{
				this.iterateCountField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(0.001D)]
		public double iterateDelta
		{
			get
			{
				return this.iterateDeltaField;
			}
			set
			{
				this.iterateDeltaField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool fullPrecision
		{
			get
			{
				return this.fullPrecisionField;
			}
			set
			{
				this.fullPrecisionField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool calcCompleted
		{
			get
			{
				return this.calcCompletedField;
			}
			set
			{
				this.calcCompletedField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool calcOnSave
		{
			get
			{
				return this.calcOnSaveField;
			}
			set
			{
				this.calcOnSaveField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool concurrentCalc
		{
			get
			{
				return this.concurrentCalcField;
			}
			set
			{
				this.concurrentCalcField = value;
			}
		}
		[XmlAttribute]
		public uint concurrentManualCount
		{
			get
			{
				return this.concurrentManualCountField;
			}
			set
			{
				this.concurrentManualCountField = value;
			}
		}

		[XmlIgnore]
		public bool concurrentManualCountSpecified
		{
			get
			{
				return this.concurrentManualCountFieldSpecified;
			}
			set
			{
				this.concurrentManualCountFieldSpecified = value;
			}
		}
		[XmlAttribute]
		public bool forceFullCalc
		{
			get
			{
				return this.forceFullCalcField;
			}
			set
			{
				this.forceFullCalcField = value;
			}
		}

		[XmlIgnore]
		public bool forceFullCalcSpecified
		{
			get
			{
				return this.forceFullCalcFieldSpecified;
			}
			set
			{
				this.forceFullCalcFieldSpecified = value;
			}
		}
	}


	public enum ST_RefMode
	{


		A1,


		R1C1,
	}






	public enum ST_Visibility
	{


		visible,


		hidden,


		veryHidden,
	}

	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_WorkbookProtection
	{

		private byte[] workbookPasswordField;

		private byte[] revisionsPasswordField;

		private bool lockStructureField;

		private bool lockWindowsField;

		private bool lockRevisionField;
		public static CT_WorkbookProtection Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_WorkbookProtection ctObj = new CT_WorkbookProtection();
			ctObj.workbookPassword = XmlHelper.ReadBytes(node.Attribute("workbookPassword"));
			ctObj.revisionsPassword = XmlHelper.ReadBytes(node.Attribute("revisionsPassword"));
			ctObj.lockStructure = XmlHelper.ReadBool(node.Attribute("lockStructure"));
			ctObj.lockWindows = XmlHelper.ReadBool(node.Attribute("lockWindows"));
			ctObj.lockRevision = XmlHelper.ReadBool(node.Attribute("lockRevision"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "workbookPassword", this.workbookPassword);
			XmlHelper.WriteAttribute(sw, "revisionsPassword", this.revisionsPassword);
			XmlHelper.WriteAttribute(sw, "lockStructure", this.lockStructure);
			XmlHelper.WriteAttribute(sw, "lockWindows", this.lockWindows);
			XmlHelper.WriteAttribute(sw, "lockRevision", this.lockRevision);
			sw.Write("/>");
		}

		public CT_WorkbookProtection()
		{
			this.lockStructureField = false;
			this.lockWindowsField = false;
			this.lockRevisionField = false;
		}
		[XmlAttribute]
		public byte[] workbookPassword
		{
			get
			{
				return this.workbookPasswordField;
			}
			set
			{
				this.workbookPasswordField = value;
			}
		}
		[XmlAttribute]
		public byte[] revisionsPassword
		{
			get
			{
				return this.revisionsPasswordField;
			}
			set
			{
				this.revisionsPasswordField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool lockStructure
		{
			get
			{
				return this.lockStructureField;
			}
			set
			{
				this.lockStructureField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool lockWindows
		{
			get
			{
				return this.lockWindowsField;
			}
			set
			{
				this.lockWindowsField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool lockRevision
		{
			get
			{
				return this.lockRevisionField;
			}
			set
			{
				this.lockRevisionField = value;
			}
		}
	}

	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_WorkbookPr
	{

		private bool date1904Field;
		private bool date1904FieldSpecifiedField = true;

		private ST_Objects showObjectsField;

		private bool showBorderUnselectedTablesField;

		private bool filterPrivacyField;

		private bool promptedSolutionsField;

		private bool showInkAnnotationField;

		private bool backupFileField;

		private bool saveExternalLinkValuesField;

		private ST_UpdateLinks updateLinksField;

		private string codeNameField;

		private bool hidePivotFieldListField;

		private bool showPivotChartFilterField;

		private bool allowRefreshQueryField;

		private bool publishItemsField;

		private bool checkCompatibilityField;

		private bool autoCompressPicturesField;

		private bool refreshAllConnectionsField;

		private uint defaultThemeVersionField;

		private bool defaultThemeVersionFieldSpecified;

		public bool IsSetDate1904()
		{
			return this.date1904FieldSpecifiedField;
		}
		public static CT_WorkbookPr Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_WorkbookPr ctObj = new CT_WorkbookPr();
			ctObj.date1904 = XmlHelper.ReadBool(node.Attribute("date1904"));
			ctObj.date1904Specified = node.Attribute("date1904") != null;
			if (node.Attribute("showObjects") != null)
				ctObj.showObjects = (ST_Objects)Enum.Parse(typeof(ST_Objects), node.Attribute("showObjects").Value);
			ctObj.showBorderUnselectedTables = XmlHelper.ReadBool(node.Attribute("showBorderUnselectedTables"), true);
			ctObj.filterPrivacy = XmlHelper.ReadBool(node.Attribute("filterPrivacy"));
			ctObj.promptedSolutions = XmlHelper.ReadBool(node.Attribute("promptedSolutions"));
			ctObj.showInkAnnotation = XmlHelper.ReadBool(node.Attribute("showInkAnnotation"), true);
			ctObj.backupFile = XmlHelper.ReadBool(node.Attribute("backupFile"));
			ctObj.saveExternalLinkValues = XmlHelper.ReadBool(node.Attribute("saveExternalLinkValues"), true);
			if (node.Attribute("updateLinks") != null)
				ctObj.updateLinks = (ST_UpdateLinks)Enum.Parse(typeof(ST_UpdateLinks), node.Attribute("updateLinks").Value);
			ctObj.codeName = XmlHelper.ReadString(node.Attribute("codeName"));
			ctObj.hidePivotFieldList = XmlHelper.ReadBool(node.Attribute("hidePivotFieldList"));
			ctObj.showPivotChartFilter = XmlHelper.ReadBool(node.Attribute("showPivotChartFilter"));
			ctObj.allowRefreshQuery = XmlHelper.ReadBool(node.Attribute("allowRefreshQuery"));
			ctObj.publishItems = XmlHelper.ReadBool(node.Attribute("publishItems"));
			ctObj.checkCompatibility = XmlHelper.ReadBool(node.Attribute("checkCompatibility"));
			ctObj.autoCompressPictures = XmlHelper.ReadBool(node.Attribute("autoCompressPictures"), true);
			ctObj.refreshAllConnections = XmlHelper.ReadBool(node.Attribute("refreshAllConnections"));
			ctObj.defaultThemeVersion = XmlHelper.ReadUInt(node.Attribute("defaultThemeVersion"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "date1904", this.date1904, false);
			if (this.showObjects != ST_Objects.all)
				XmlHelper.WriteAttribute(sw, "showObjects", this.showObjects.ToString());
			if (!showBorderUnselectedTables)
				XmlHelper.WriteAttribute(sw, "showBorderUnselectedTables", this.showBorderUnselectedTables);
			XmlHelper.WriteAttribute(sw, "filterPrivacy", this.filterPrivacy, false);
			XmlHelper.WriteAttribute(sw, "promptedSolutions", this.promptedSolutions, false);
			if (!showInkAnnotationField)
				XmlHelper.WriteAttribute(sw, "showInkAnnotation", this.showInkAnnotation, false);
			XmlHelper.WriteAttribute(sw, "backupFile", this.backupFile, false);
			if (!saveExternalLinkValues)
				XmlHelper.WriteAttribute(sw, "saveExternalLinkValues", this.saveExternalLinkValues);
			if (this.updateLinks != ST_UpdateLinks.userSet)
				XmlHelper.WriteAttribute(sw, "updateLinks", this.updateLinks.ToString());
			XmlHelper.WriteAttribute(sw, "codeName", this.codeName);
			XmlHelper.WriteAttribute(sw, "hidePivotFieldList", this.hidePivotFieldList, false);
			XmlHelper.WriteAttribute(sw, "showPivotChartFilter", this.showPivotChartFilter, false);
			XmlHelper.WriteAttribute(sw, "allowRefreshQuery", this.allowRefreshQuery, false);
			XmlHelper.WriteAttribute(sw, "publishItems", this.publishItems, false);
			XmlHelper.WriteAttribute(sw, "checkCompatibility", this.checkCompatibility, false);
			XmlHelper.WriteAttribute(sw, "autoCompressPictures", this.autoCompressPictures, false);
			XmlHelper.WriteAttribute(sw, "refreshAllConnections", this.refreshAllConnections, false);
			XmlHelper.WriteAttribute(sw, "defaultThemeVersion", this.defaultThemeVersion);
			sw.Write("/>");
		}

		public CT_WorkbookPr()
		{
			this.date1904Field = false;
			this.showObjectsField = ST_Objects.all;
			this.showBorderUnselectedTablesField = true;
			this.filterPrivacyField = false;
			this.promptedSolutionsField = false;
			this.showInkAnnotationField = true;
			this.backupFileField = false;
			this.saveExternalLinkValuesField = true;
			this.updateLinksField = ST_UpdateLinks.userSet;
			this.hidePivotFieldListField = false;
			this.showPivotChartFilterField = false;
			this.allowRefreshQueryField = false;
			this.publishItemsField = false;
			this.checkCompatibilityField = false;
			this.autoCompressPicturesField = true;
			this.refreshAllConnectionsField = false;
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool date1904
		{
			get
			{
				return this.date1904Field;
			}
			set
			{
				this.date1904Field = value;
			}
		}
		[XmlIgnore]
		public bool date1904Specified
		{
			get
			{
				return date1904FieldSpecifiedField;
			}
			set
			{
				date1904FieldSpecifiedField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(ST_Objects.all)]
		public ST_Objects showObjects
		{
			get
			{
				return this.showObjectsField;
			}
			set
			{
				this.showObjectsField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool showBorderUnselectedTables
		{
			get
			{
				return this.showBorderUnselectedTablesField;
			}
			set
			{
				this.showBorderUnselectedTablesField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool filterPrivacy
		{
			get
			{
				return this.filterPrivacyField;
			}
			set
			{
				this.filterPrivacyField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool promptedSolutions
		{
			get
			{
				return this.promptedSolutionsField;
			}
			set
			{
				this.promptedSolutionsField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool showInkAnnotation
		{
			get
			{
				return this.showInkAnnotationField;
			}
			set
			{
				this.showInkAnnotationField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool backupFile
		{
			get
			{
				return this.backupFileField;
			}
			set
			{
				this.backupFileField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool saveExternalLinkValues
		{
			get
			{
				return this.saveExternalLinkValuesField;
			}
			set
			{
				this.saveExternalLinkValuesField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(ST_UpdateLinks.userSet)]
		public ST_UpdateLinks updateLinks
		{
			get
			{
				return this.updateLinksField;
			}
			set
			{
				this.updateLinksField = value;
			}
		}
		[XmlAttribute]
		public string codeName
		{
			get
			{
				return this.codeNameField;
			}
			set
			{
				this.codeNameField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool hidePivotFieldList
		{
			get
			{
				return this.hidePivotFieldListField;
			}
			set
			{
				this.hidePivotFieldListField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool showPivotChartFilter
		{
			get
			{
				return this.showPivotChartFilterField;
			}
			set
			{
				this.showPivotChartFilterField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool allowRefreshQuery
		{
			get
			{
				return this.allowRefreshQueryField;
			}
			set
			{
				this.allowRefreshQueryField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool publishItems
		{
			get
			{
				return this.publishItemsField;
			}
			set
			{
				this.publishItemsField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool checkCompatibility
		{
			get
			{
				return this.checkCompatibilityField;
			}
			set
			{
				this.checkCompatibilityField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(true)]
		public bool autoCompressPictures
		{
			get
			{
				return this.autoCompressPicturesField;
			}
			set
			{
				this.autoCompressPicturesField = value;
			}
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool refreshAllConnections
		{
			get
			{
				return this.refreshAllConnectionsField;
			}
			set
			{
				this.refreshAllConnectionsField = value;
			}
		}
		[XmlAttribute]
		public uint defaultThemeVersion
		{
			get
			{
				return this.defaultThemeVersionField;
			}
			set
			{
				this.defaultThemeVersionField = value;
			}
		}

		[XmlIgnore]
		public bool defaultThemeVersionSpecified
		{
			get
			{
				return this.defaultThemeVersionFieldSpecified;
			}
			set
			{
				this.defaultThemeVersionFieldSpecified = value;
			}
		}
	}

	public enum ST_UpdateLinks
	{


		userSet,


		never,


		always,
	}

	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_FileSharing
	{

		private bool readOnlyRecommendedField;

		private string userNameField;

		private byte[] reservationPasswordField;

		public CT_FileSharing()
		{
			this.readOnlyRecommendedField = false;
		}
		public static CT_FileSharing Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_FileSharing ctObj = new CT_FileSharing();
			ctObj.readOnlyRecommended = XmlHelper.ReadBool(node.Attribute("readOnlyRecommended"));
			ctObj.userName = XmlHelper.ReadString(node.Attribute("userName"));
			ctObj.reservationPassword = XmlHelper.ReadBytes(node.Attribute("reservationPassword"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "readOnlyRecommended", this.readOnlyRecommended);
			XmlHelper.WriteAttribute(sw, "userName", this.userName);
			XmlHelper.WriteAttribute(sw, "reservationPassword", this.reservationPassword);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}
		[XmlAttribute]
		[DefaultValue(false)]
		public bool readOnlyRecommended
		{
			get
			{
				return this.readOnlyRecommendedField;
			}
			set
			{
				this.readOnlyRecommendedField = value;
			}
		}
		[XmlAttribute]
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}
		[XmlAttribute]
		public byte[] reservationPassword
		{
			get
			{
				return this.reservationPasswordField;
			}
			set
			{
				this.reservationPasswordField = value;
			}
		}
	}







	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CT_SheetBackgroundPicture
	{

		private string idField;

		// TODO is the following correct?
		[XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		public static CT_SheetBackgroundPicture Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_SheetBackgroundPicture ctObj = new CT_SheetBackgroundPicture();
			ctObj.id = XmlHelper.ReadString(node.Attribute((XNamespace)PackageNamespaces.SCHEMA_RELATIONSHIPS + "id"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

	}


}
