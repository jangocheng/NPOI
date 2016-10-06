// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Npoi.Core.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
	using System.IO;
	using System.Xml;
	using Npoi.Core.OpenXml4Net.Util;


	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextSpacingPercent
	{
		public static CT_TextSpacingPercent Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextSpacingPercent ctObj = new CT_TextSpacingPercent();
			ctObj.val = XmlHelper.ReadInt(node.Attribute("val"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write("/>");
		}

		private int valField;
		/*<xsd:restriction base="ST_Percentage">
              <xsd:minInclusive value="0" />
              <xsd:maxInclusive value="13200000" />
          </xsd:restriction>*/
		[XmlAttribute]
		public int val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}
	}


	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextSpacingPoint
	{
		public static CT_TextSpacingPoint Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextSpacingPoint ctObj = new CT_TextSpacingPoint();
			ctObj.val = XmlHelper.ReadInt(node.Attribute("val"));
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "val", this.val, true);
			sw.Write("/>");
		}

		private int valField;
		/*<xsd:restriction base="xsd:int">
              <xsd:minInclusive value="0" />
              <xsd:maxInclusive value="158400" />
          </xsd:restriction>*/
		[XmlAttribute]
		public int val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}
	}


	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextTabStop
	{

		private int posField;

		private bool posFieldSpecified;

		private ST_TextTabAlignType algnField;

		private bool algnFieldSpecified;
		public static CT_TextTabStop Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextTabStop ctObj = new CT_TextTabStop();
			ctObj.pos = XmlHelper.ReadInt(node.Attribute("pos"));
			if (node.Attribute("algn") != null)
				ctObj.algn = (ST_TextTabAlignType)Enum.Parse(typeof(ST_TextTabAlignType), node.Attribute("algn").Value);
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "pos", this.pos);
			XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			sw.Write("/>");
		}

		[XmlAttribute]
		public int pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		[XmlIgnore]
		public bool posSpecified
		{
			get
			{
				return this.posFieldSpecified;
			}
			set
			{
				this.posFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public ST_TextTabAlignType algn
		{
			get
			{
				return this.algnField;
			}
			set
			{
				this.algnField = value;
			}
		}

		[XmlIgnore]
		public bool algnSpecified
		{
			get
			{
				return this.algnFieldSpecified;
			}
			set
			{
				this.algnFieldSpecified = value;
			}
		}
	}


	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	public enum ST_TextTabAlignType
	{

		/// <remarks/>
		l,

		/// <remarks/>
		ctr,

		/// <remarks/>
		r,

		/// <remarks/>
		dec,
	}


	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextTabStopList
	{

		private List<CT_TextTabStop> tabField;

		public CT_TextTabStopList()
		{
			this.tabField = new List<CT_TextTabStop>();
		}

		[XmlElement("tab", Order = 0)]
		public List<CT_TextTabStop> tab
		{
			get
			{
				return this.tabField;
			}
			set
			{
				this.tabField = value;
			}
		}

		internal void Write(StreamWriter sw, string p)
		{
			sw.Write("<a:{0}>", p);
			if (this.tab != null)
			{
				foreach (CT_TextTabStop tts in tab)
				{
					tts.Write(sw, "tab");
				}
			}
			sw.Write("</a:{0}>", p);
		}

		internal static CT_TextTabStopList Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			CT_TextTabStopList ttsl = new CT_TextTabStopList();
			ttsl.tab = new List<CT_TextTabStop>();
			foreach (XElement childNode in node.ChildElements())
			{
				if (childNode.Name.LocalName == "tab")
					ttsl.tab.Add(CT_TextTabStop.Parse(childNode, namespaceManager));
			}
			return ttsl;
		}

		public CT_TextTabStop AddNewTab()
		{
			this.tabField.Add(new CT_TextTabStop());
			return this.tabField[this.tabField.Count - 1];
		}

		public int SizeOfTabArray()
		{
			return tabField.Count;
		}

		public CT_TextTabStop GetTabArray(int idx)
		{
			return tabField[idx];
		}
	}


	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextLineBreak
	{

		private CT_TextCharacterProperties rPrField;

		public CT_TextLineBreak()
		{
			//this.rPrField = new CT_TextCharacterProperties();
		}

		public static CT_TextLineBreak Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextLineBreak ctObj = new CT_TextLineBreak();
			foreach (XElement childNode in node.ChildElements())
			{
				if (childNode.Name.LocalName == "rPr")
					ctObj.rPr = CT_TextCharacterProperties.Parse(childNode, namespaceManager);
			}
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}>", nodeName));
			if (this.rPr != null)
				this.rPr.Write(sw, "rPr");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		[XmlElement(Order = 0)]
		public CT_TextCharacterProperties rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		public CT_TextCharacterProperties AddNewRPr()
		{
			this.rPr = new CT_TextCharacterProperties();
			return rPr;
		}
	}

	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextSpacing
	{
		private CT_TextSpacingPercent spcPctField;
		private CT_TextSpacingPoint spcPtsField;
		public static CT_TextSpacing Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextSpacing ctObj = new CT_TextSpacing();
			foreach (XElement childNode in node.ChildElements())
			{
				if (childNode.Name.LocalName == "spcPct")
					ctObj.spcPct = CT_TextSpacingPercent.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "spcPts")
					ctObj.spcPts = CT_TextSpacingPoint.Parse(childNode, namespaceManager);
			}
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}>", nodeName));
			if (this.spcPct != null)
				this.spcPct.Write(sw, "spcPct");
			if (this.spcPts != null)
				this.spcPts.Write(sw, "spcPts");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}
		public CT_TextSpacingPercent spcPct
		{
			get { return this.spcPctField; }
			set { this.spcPctField = value; }
		}
		public CT_TextSpacingPoint spcPts
		{
			get { return this.spcPtsField; }
			set { this.spcPtsField = value; }
		}

		public CT_TextSpacingPercent AddNewSpcPct()
		{
			this.spcPctField = new CT_TextSpacingPercent();
			return this.spcPctField;
		}

		public CT_TextSpacingPoint AddNewSpcPts()
		{
			this.spcPtsField = new CT_TextSpacingPoint();
			return this.spcPtsField;
		}

		public bool IsSetSpcPct()
		{
			return this.spcPctField != null;
		}

		public bool IsSetSpcPts()
		{
			return this.spcPtsField != null;
		}
	}


	[Serializable]
	[System.Diagnostics.DebuggerStepThrough]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextParagraph
	{
		public static CT_TextParagraph Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextParagraph ctObj = new CT_TextParagraph();
			ctObj.r = new List<CT_RegularTextRun>();
			ctObj.br = new List<CT_TextLineBreak>();
			ctObj.fld = new List<CT_TextField>();
			ctObj.items = new List<object>();
			foreach (XElement childNode in node.ChildElements())
			{
				if (childNode.Name.LocalName == "pPr")
				{
					ctObj.pPr = CT_TextParagraphProperties.Parse(childNode, namespaceManager);
					ctObj.items.Add(ctObj.pPr);
				}
				else if (childNode.Name.LocalName == "endParaRPr")
				{
					ctObj.endParaRPr = CT_TextCharacterProperties.Parse(childNode, namespaceManager);
					ctObj.items.Add(ctObj.endParaRPr);
				}
				else if (childNode.Name.LocalName == "r")
				{
					CT_RegularTextRun r = CT_RegularTextRun.Parse(childNode, namespaceManager);
					ctObj.r.Add(r);
					ctObj.items.Add(r);
				}
				else if (childNode.Name.LocalName == "br")
				{
					CT_TextLineBreak br = CT_TextLineBreak.Parse(childNode, namespaceManager);
					ctObj.br.Add(br);
					ctObj.items.Add(br);
				}
				else if (childNode.Name.LocalName == "fld")
				{
					CT_TextField fld = CT_TextField.Parse(childNode, namespaceManager);
					ctObj.fld.Add(fld);
					ctObj.items.Add(fld);
				}
			}
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.pPr != null)
				this.pPr.Write(sw, "pPr");
			//if (this.r != null)
			//{
			//    foreach (CT_RegularTextRun x in this.r)
			//    {
			//        x.Write(sw, "r");
			//    }
			//}
			//if (this.br != null)
			//{
			//    foreach (CT_TextLineBreak x in this.br)
			//    {
			//        x.Write(sw, "br");
			//    }
			//}
			//if (this.fld != null)
			//{
			//    foreach (CT_TextField x in this.fld)
			//    {
			//        x.Write(sw, "fld");
			//    }
			//}
			foreach (object o in items)
			{
				if (o is CT_RegularTextRun)
				{
					(o as CT_RegularTextRun).Write(sw, "r");
				}
				else if (o is CT_TextLineBreak)
				{
					(o as CT_TextLineBreak).Write(sw, "br");
				}
				else if (o is CT_TextField)
				{
					(o as CT_TextField).Write(sw, "fld");
				}
			}
			if (this.endParaRPr != null)
				this.endParaRPr.Write(sw, "endParaRPr");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		private CT_TextParagraphProperties pPrField;

		private List<CT_RegularTextRun> rField = new List<CT_RegularTextRun>();

		private List<CT_TextLineBreak> brField = new List<CT_TextLineBreak>();

		private List<CT_TextField> fldField = new List<CT_TextField>();

		private List<object> itemsField = new List<object>();
		[XmlIgnore]
		public List<object> items
		{
			get { return itemsField; }
			set { itemsField = value; }
		}
		private CT_TextCharacterProperties endParaRPrField;

		public CT_RegularTextRun AddNewR()
		{
			if (this.rField == null)
				this.rField = new List<CT_RegularTextRun>();
			CT_RegularTextRun rtr = new CT_RegularTextRun();
			this.rField.Add(rtr);
			this.itemsField.Add(rtr);
			return rtr;
		}
		public CT_TextParagraphProperties AddNewPPr()
		{
			this.pPrField = new CT_TextParagraphProperties();
			return this.pPrField;
		}
		public CT_TextCharacterProperties AddNewEndParaRPr()
		{
			this.endParaRPrField = new CT_TextCharacterProperties();
			return this.endParaRPrField;
		}

		public CT_TextParagraphProperties pPr
		{
			get
			{
				return this.pPrField;
			}
			set
			{
				this.pPrField = value;
			}
		}


		[XmlElement("r")]
		public List<CT_RegularTextRun> r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}


		[XmlElement("br")]
		public List<CT_TextLineBreak> br
		{
			get
			{
				return this.brField;
			}
			set
			{
				this.brField = value;
			}
		}


		[XmlElement("fld")]
		public List<CT_TextField> fld
		{
			get
			{
				return this.fldField;
			}
			set
			{
				this.fldField = value;
			}
		}


		public CT_TextCharacterProperties endParaRPr
		{
			get
			{
				return this.endParaRPrField;
			}
			set
			{
				this.endParaRPrField = value;
			}
		}

		public int SizeOfRArray()
		{
			return rField.Count;
		}

		public bool IsSetPPr()
		{
			return this.pPrField != null;
		}

		public CT_TextLineBreak AddNewBr()
		{
			CT_TextLineBreak br = new CT_TextLineBreak();
			this.brField.Add(br);
			this.itemsField.Add(br);
			return br;
		}
	}

	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextParagraphProperties
	{

		private CT_TextSpacing lnSpcField;

		private CT_TextSpacing spcBefField;

		private CT_TextSpacing spcAftField;

		private CT_TextBulletColorFollowText buClrTxField;

		private CT_Color buClrField;

		private CT_TextBulletSizeFollowText buSzTxField;

		private CT_TextBulletSizePercent buSzPctField;

		private CT_TextBulletSizePoint buSzPtsField;

		private CT_TextBulletTypefaceFollowText buFontTxField;

		private CT_TextFont buFontField;

		private CT_TextNoBullet buNoneField;

		private CT_TextAutonumberBullet buAutoNumField;

		private CT_TextCharBullet buCharField;

		private CT_TextBlipBullet buBlipField;

		private CT_TextTabStopList tabLstField;

		private CT_TextCharacterProperties defRPrField;

		private CT_OfficeArtExtensionList extLstField;

		private int marLField;

		private bool marLFieldSpecified;

		private int marRField;

		private bool marRFieldSpecified;

		private int lvlField;

		private bool lvlFieldSpecified;

		private int indentField;

		private bool indentFieldSpecified;

		private ST_TextAlignType algnField;

		private bool algnFieldSpecified;

		private int defTabSzField;

		private bool defTabSzFieldSpecified;

		private bool rtlField;

		private bool rtlFieldSpecified;

		private bool eaLnBrkField;

		private bool eaLnBrkFieldSpecified;

		private ST_TextFontAlignType fontAlgnField;

		private bool fontAlgnFieldSpecified;

		private bool latinLnBrkField;

		private bool latinLnBrkFieldSpecified;

		private bool hangingPunctField;

		private bool hangingPunctFieldSpecified;

		public CT_TextParagraphProperties()
		{
			this.algn = ST_TextAlignType.l;
		}

		public static CT_TextParagraphProperties Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextParagraphProperties ctObj = new CT_TextParagraphProperties();
			ctObj.marL = XmlHelper.ReadInt(node.Attribute("marL"));
			ctObj.marR = XmlHelper.ReadInt(node.Attribute("marR"));
			ctObj.lvl = XmlHelper.ReadInt(node.Attribute("lvl"));
			ctObj.indent = XmlHelper.ReadInt(node.Attribute("indent"));
			if (node.Attribute("algn") != null)
				ctObj.algn = (ST_TextAlignType)Enum.Parse(typeof(ST_TextAlignType), node.Attribute("algn").Value);
			else
				ctObj.algn = ST_TextAlignType.l;
			ctObj.defTabSz = XmlHelper.ReadInt(node.Attribute("defTabSz"));
			ctObj.rtl = XmlHelper.ReadBool(node.Attribute("rtl"));
			ctObj.eaLnBrk = XmlHelper.ReadBool(node.Attribute("eaLnBrk"));
			if (node.Attribute("fontAlgn") != null)
				ctObj.fontAlgn = (ST_TextFontAlignType)Enum.Parse(typeof(ST_TextFontAlignType), node.Attribute("fontAlgn").Value);
			ctObj.latinLnBrk = XmlHelper.ReadBool(node.Attribute("latinLnBrk"));
			ctObj.hangingPunct = XmlHelper.ReadBool(node.Attribute("hangingPunct"));

			foreach (XElement childNode in node.ChildElements())
			{
				if (childNode.Name.LocalName == "lnSpc")
					ctObj.lnSpc = CT_TextSpacing.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "spcBef")
					ctObj.spcBef = CT_TextSpacing.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "spcAft")
					ctObj.spcAft = CT_TextSpacing.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buClrTx")
					ctObj.buClrTx = new CT_TextBulletColorFollowText();
				else if (childNode.Name.LocalName == "buClr")
					ctObj.buClr = CT_Color.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buSzTx")
					ctObj.buSzTx = new CT_TextBulletSizeFollowText();
				else if (childNode.Name.LocalName == "buSzPct")
					ctObj.buSzPct = CT_TextBulletSizePercent.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buSzPts")
					ctObj.buSzPts = CT_TextBulletSizePoint.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buFontTx")
					ctObj.buFontTx = new CT_TextBulletTypefaceFollowText();
				else if (childNode.Name.LocalName == "buFont")
					ctObj.buFont = CT_TextFont.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buNone")
					ctObj.buNone = new CT_TextNoBullet();
				else if (childNode.Name.LocalName == "buAutoNum")
					ctObj.buAutoNum = CT_TextAutonumberBullet.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buChar")
					ctObj.buChar = CT_TextCharBullet.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "buBlip")
					ctObj.buBlip = CT_TextBlipBullet.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "defRPr")
					ctObj.defRPr = CT_TextCharacterProperties.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "extLst")
					ctObj.extLst = CT_OfficeArtExtensionList.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "tabLst")
					ctObj.tabLst = CT_TextTabStopList.Parse(childNode, namespaceManager);
			}
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "marL", this.marL);
			XmlHelper.WriteAttribute(sw, "marR", this.marR);
			XmlHelper.WriteAttribute(sw, "lvl", this.lvl, true);
			XmlHelper.WriteAttribute(sw, "indent", this.indent);
			if (algn != ST_TextAlignType.l)
				XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			XmlHelper.WriteAttribute(sw, "defTabSz", this.defTabSz);
			XmlHelper.WriteAttribute(sw, "rtl", this.rtl, false);
			XmlHelper.WriteAttribute(sw, "eaLnBrk", this.eaLnBrk, false);
			if (this.fontAlgn != ST_TextFontAlignType.auto)
				XmlHelper.WriteAttribute(sw, "fontAlgn", this.fontAlgn.ToString());
			XmlHelper.WriteAttribute(sw, "latinLnBrk", this.latinLnBrk, false);
			XmlHelper.WriteAttribute(sw, "hangingPunct", this.hangingPunct, false);
			sw.Write(">");
			if (this.lnSpc != null)
				this.lnSpc.Write(sw, "lnSpc");
			if (this.spcBef != null)
				this.spcBef.Write(sw, "spcBef");
			if (this.spcAft != null)
				this.spcAft.Write(sw, "spcAft");
			if (this.buClrTx != null)
				sw.Write("<a:buClrTx/>");
			if (this.buClr != null)
				this.buClr.Write(sw, "buClr");
			if (this.buSzTx != null)
				sw.Write("<a:buSzTx/>");
			if (this.buSzPct != null)
				this.buSzPct.Write(sw, "buSzPct");
			if (this.buSzPts != null)
				this.buSzPts.Write(sw, "buSzPts");
			if (this.buFontTx != null)
				sw.Write("<a:buFontTx/>");
			if (this.buFont != null)
				this.buFont.Write(sw, "buFont");
			if (this.buNone != null)
				sw.Write("<a:buNone/>");
			if (this.buAutoNum != null)
				this.buAutoNum.Write(sw, "buAutoNum");
			if (this.buChar != null)
				this.buChar.Write(sw, "buChar");
			if (this.buBlip != null)
				this.buBlip.Write(sw, "buBlip");
			if (this.tabLstField != null)
			{
				this.tabLstField.Write(sw, "tabLst");
			}
			if (this.defRPr != null)
				this.defRPr.Write(sw, "defRPr");
			if (this.extLst != null)
				this.extLst.Write(sw, "extLst");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		[XmlElement(Order = 0)]
		public CT_TextSpacing lnSpc
		{
			get
			{
				return this.lnSpcField;
			}
			set
			{
				this.lnSpcField = value;
			}
		}

		[XmlElement(Order = 1)]
		public CT_TextSpacing spcBef
		{
			get
			{
				return this.spcBefField;
			}
			set
			{
				this.spcBefField = value;
			}
		}

		[XmlElement(Order = 2)]
		public CT_TextSpacing spcAft
		{
			get
			{
				return this.spcAftField;
			}
			set
			{
				this.spcAftField = value;
			}
		}

		[XmlElement(Order = 3)]
		public CT_TextBulletColorFollowText buClrTx
		{
			get
			{
				return this.buClrTxField;
			}
			set
			{
				this.buClrTxField = value;
			}
		}

		[XmlElement(Order = 4)]
		public CT_Color buClr
		{
			get
			{
				return this.buClrField;
			}
			set
			{
				this.buClrField = value;
			}
		}

		[XmlElement(Order = 5)]
		public CT_TextBulletSizeFollowText buSzTx
		{
			get
			{
				return this.buSzTxField;
			}
			set
			{
				this.buSzTxField = value;
			}
		}

		[XmlElement(Order = 6)]
		public CT_TextBulletSizePercent buSzPct
		{
			get
			{
				return this.buSzPctField;
			}
			set
			{
				this.buSzPctField = value;
			}
		}

		[XmlElement(Order = 7)]
		public CT_TextBulletSizePoint buSzPts
		{
			get
			{
				return this.buSzPtsField;
			}
			set
			{
				this.buSzPtsField = value;
			}
		}

		[XmlElement(Order = 8)]
		public CT_TextBulletTypefaceFollowText buFontTx
		{
			get
			{
				return this.buFontTxField;
			}
			set
			{
				this.buFontTxField = value;
			}
		}

		[XmlElement(Order = 9)]
		public CT_TextFont buFont
		{
			get
			{
				return this.buFontField;
			}
			set
			{
				this.buFontField = value;
			}
		}

		[XmlElement(Order = 10)]
		public CT_TextNoBullet buNone
		{
			get
			{
				return this.buNoneField;
			}
			set
			{
				this.buNoneField = value;
			}
		}

		[XmlElement(Order = 11)]
		public CT_TextAutonumberBullet buAutoNum
		{
			get
			{
				return this.buAutoNumField;
			}
			set
			{
				this.buAutoNumField = value;
			}
		}

		[XmlElement(Order = 12)]
		public CT_TextCharBullet buChar
		{
			get
			{
				return this.buCharField;
			}
			set
			{
				this.buCharField = value;
			}
		}

		[XmlElement(Order = 13)]
		public CT_TextBlipBullet buBlip
		{
			get
			{
				return this.buBlipField;
			}
			set
			{
				this.buBlipField = value;
			}
		}

		[XmlElement(Order = 14)]
		public CT_TextTabStopList tabLst
		{
			get
			{
				return this.tabLstField;
			}
			set
			{
				this.tabLstField = value;
			}
		}

		[XmlElement(Order = 15)]
		public CT_TextCharacterProperties defRPr
		{
			get
			{
				return this.defRPrField;
			}
			set
			{
				this.defRPrField = value;
			}
		}

		[XmlElement(Order = 16)]
		public CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		[XmlAttribute]
		public int marL
		{
			get
			{
				return this.marLField;
			}
			set
			{
				this.marLField = value;
				this.marLFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool marLSpecified
		{
			get
			{
				return this.marLFieldSpecified;
			}
			set
			{
				this.marLFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public int marR
		{
			get
			{
				return this.marRField;
			}
			set
			{
				this.marRField = value;
				this.marRFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool marRSpecified
		{
			get
			{
				return this.marRFieldSpecified;
			}
			set
			{
				this.marRFieldSpecified = value;
			}
		}
		/*<xsd:restriction base="xsd:int">
            <xsd:minInclusive value="0" />
            <xsd:maxInclusive value="8" />
          </xsd:restriction>*/
		[XmlAttribute]
		public int lvl
		{
			get
			{
				return this.lvlField;
			}
			set
			{
				this.lvlField = value;
				this.lvlFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool lvlSpecified
		{
			get
			{
				return this.lvlFieldSpecified;
			}
			set
			{
				this.lvlFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public int indent
		{
			get
			{
				return this.indentField;
			}
			set
			{
				this.indentField = value;
				this.indentFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool indentSpecified
		{
			get
			{
				return this.indentFieldSpecified;
			}
			set
			{
				this.indentFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public ST_TextAlignType algn
		{
			get
			{
				return this.algnField;
			}
			set
			{
				this.algnField = value;
				this.algnFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool algnSpecified
		{
			get
			{
				return this.algnFieldSpecified;
			}
			set
			{
				this.algnFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public int defTabSz
		{
			get
			{
				return this.defTabSzField;
			}
			set
			{
				this.defTabSzField = value;
				this.defTabSzFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool defTabSzSpecified
		{
			get
			{
				return this.defTabSzFieldSpecified;
			}
			set
			{
				this.defTabSzFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public bool rtl
		{
			get
			{
				return this.rtlField;
			}
			set
			{
				this.rtlField = value;
				this.rtlFieldSpecified = value;
			}
		}

		[XmlIgnore]
		public bool rtlSpecified
		{
			get
			{
				return this.rtlFieldSpecified;
			}
			set
			{
				this.rtlFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public bool eaLnBrk
		{
			get
			{
				return this.eaLnBrkField;
			}
			set
			{
				this.eaLnBrkField = value;
				this.eaLnBrkFieldSpecified = value;
			}
		}

		[XmlIgnore]
		public bool eaLnBrkSpecified
		{
			get
			{
				return this.eaLnBrkFieldSpecified;
			}
			set
			{
				this.eaLnBrkFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public ST_TextFontAlignType fontAlgn
		{
			get
			{
				return this.fontAlgnField;
			}
			set
			{
				this.fontAlgnField = value;
				this.fontAlgnFieldSpecified = true;
			}
		}

		[XmlIgnore]
		public bool fontAlgnSpecified
		{
			get
			{
				return this.fontAlgnFieldSpecified;
			}
			set
			{
				this.fontAlgnFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public bool latinLnBrk
		{
			get
			{
				return this.latinLnBrkField;
			}
			set
			{
				this.latinLnBrkField = value;
				this.latinLnBrkFieldSpecified = value;
			}
		}

		[XmlIgnore]
		public bool latinLnBrkSpecified
		{
			get
			{
				return this.latinLnBrkFieldSpecified;
			}
			set
			{
				this.latinLnBrkFieldSpecified = value;
			}
		}

		[XmlAttribute]
		public bool hangingPunct
		{
			get
			{
				return this.hangingPunctField;
			}
			set
			{
				this.hangingPunctField = value;
				this.hangingPunctFieldSpecified = value;
			}
		}

		[XmlIgnore]
		public bool hangingPunctSpecified
		{
			get
			{
				return this.hangingPunctFieldSpecified;
			}
			set
			{
				this.hangingPunctFieldSpecified = value;
			}
		}

		public bool IsSetAlgn()
		{
			return this.algnFieldSpecified;
		}

		public bool IsSetBuNone()
		{
			return this.buNoneField != null;
		}

		public bool IsSetBuFont()
		{
			return this.buFontField != null;
		}

		public bool IsSetBuChar()
		{
			return this.buCharField != null;
		}

		public bool IsSetBuAutoNum()
		{
			return this.buAutoNumField != null;
		}

		public void AddNewBuNone()
		{
			this.buNoneField = new CT_TextNoBullet();
		}

		public bool IsSetBuBlip()
		{
			return this.buBlipField != null;
		}

		public bool IsSetBuClr()
		{
			return this.buClrField != null;
		}

		public bool IsSetBuClrTx()
		{
			return this.buClrTxField != null;
		}

		public bool IsSetBuFontTx()
		{
			return this.buFontTxField != null;
		}

		public bool IsSetBuSzPct()
		{
			return this.buSzPctField != null;
		}

		public bool IsSetBuSzPts()
		{
			return this.buSzPtsField != null;
		}

		public bool IsSetBuSzTx()
		{
			return this.buSzTxField != null;
		}

		public CT_TextCharBullet AddNewBuChar()
		{
			this.buCharField = new CT_TextCharBullet();
			return this.buCharField;
		}

		public CT_TextFont AddNewBuFont()
		{
			this.buFontField = new CT_TextFont();
			return this.buFontField;
		}

		public void UnsetBuNone()
		{
			this.buNoneField = null;
		}

		public void UnsetBuSzTx()
		{
			this.buSzTxField = null;
		}

		public void UnsetBuSzPts()
		{
			this.buSzPtsField = null;
		}

		public void UnsetBuAutoNum()
		{
			this.buAutoNumField = null;
		}

		public void UnsetBuBlip()
		{
			this.buBlipField = null;
		}

		public void UnsetBuChar()
		{
			this.buCharField = null;
		}

		public void UnsetBuClr()
		{
			this.buClrField = null;
		}

		public void UnsetBuClrTx()
		{
			this.buClrTxField = null;
		}

		public void UnsetBuFont()
		{
			this.buFontField = null;
		}

		public void UnsetBuFontTx()
		{
			this.buFontTxField = null;
		}

		public void UnsetBuSzPct()
		{
			this.buSzPctField = null;
		}

		public void UnsetAlgn()
		{
			this.algnFieldSpecified = false;
		}

		public bool IsSetFontAlgn()
		{
			return this.fontAlgnFieldSpecified;
		}

		public void UnsetFontAlgn()
		{
			this.fontAlgnFieldSpecified = false;
		}

		public CT_Color AddNewBuClr()
		{
			this.buClrField = new CT_Color();
			return this.buClrField;
		}

		public CT_TextBulletSizePercent AddNewBuSzPct()
		{
			this.buSzPctField = new CT_TextBulletSizePercent();
			return this.buSzPctField;
		}

		public CT_TextBulletSizePoint AddNewBuSzPts()
		{
			this.buSzPtsField = new CT_TextBulletSizePoint();
			return this.buSzPtsField;
		}

		public bool IsSetIndent()
		{
			return this.indentFieldSpecified;
		}

		public void UnsetIndent()
		{
			this.indentFieldSpecified = false;
		}

		public bool IsSetMarL()
		{
			return this.marLFieldSpecified;
		}

		public void UnsetMarL()
		{
			this.marLFieldSpecified = false;
		}

		public bool IsSetMarR()
		{
			return this.marRFieldSpecified;
		}

		public void UnsetMarR()
		{
			this.marRFieldSpecified = false;
		}

		public bool IsSetDefTabSz()
		{
			return this.defTabSzFieldSpecified;
		}

		public bool IsSetTabLst()
		{
			return this.tabLstField != null;
		}

		public CT_TextTabStopList AddNewTabLst()
		{
			this.tabLstField = new CT_TextTabStopList();
			return this.tabLstField;
		}

		public bool IsSetLnSpc()
		{
			return this.lnSpcField != null;
		}

		public bool IsSetSpcBef()
		{
			return this.spcBefField != null;
		}

		public bool IsSetSpcAft()
		{
			return this.spcAftField != null;
		}

		public CT_TextAutonumberBullet AddNewBuAutoNum()
		{
			this.buAutoNumField = new CT_TextAutonumberBullet();
			return this.buAutoNumField;
		}
	}


	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	public enum ST_TextAlignType
	{

		/// <remarks/>
		l,

		/// <remarks/>
		ctr,

		/// <remarks/>
		r,

		/// <remarks/>
		just,

		/// <remarks/>
		justLow,

		/// <remarks/>
		dist,

		/// <remarks/>
		thaiDist,
	}


	[Serializable]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	public enum ST_TextFontAlignType
	{

		/// <remarks/>
		auto,

		/// <remarks/>
		t,

		/// <remarks/>
		ctr,

		/// <remarks/>
		@base,

		/// <remarks/>
		b,
	}


	[Serializable]
	[DebuggerStepThrough]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	public class CT_TextField
	{

		private CT_TextCharacterProperties rPrField;

		private CT_TextParagraphProperties pPrField;

		private string tField;

		private string idField;

		private string typeField;
		public static CT_TextField Parse(XElement node, XmlNamespaceManager namespaceManager)
		{
			if (node == null)
				return null;
			CT_TextField ctObj = new CT_TextField();
			ctObj.t = XmlHelper.ReadString(node.Attribute("t"));
			ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
			ctObj.type = XmlHelper.ReadString(node.Attribute("type"));
			foreach (XElement childNode in node.ChildElements())
			{
				if (childNode.Name.LocalName == "rPr")
					ctObj.rPr = CT_TextCharacterProperties.Parse(childNode, namespaceManager);
				else if (childNode.Name.LocalName == "pPr")
					ctObj.pPr = CT_TextParagraphProperties.Parse(childNode, namespaceManager);
			}
			return ctObj;
		}



		internal void Write(StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			XmlHelper.WriteAttribute(sw, "t", this.t);
			XmlHelper.WriteAttribute(sw, "id", this.id);
			XmlHelper.WriteAttribute(sw, "type", this.type);
			sw.Write(">");
			if (this.rPr != null)
				this.rPr.Write(sw, "rPr");
			if (this.pPr != null)
				this.pPr.Write(sw, "pPr");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		public CT_TextField()
		{
			//this.pPrField = new CT_TextParagraphProperties();
			//this.rPrField = new CT_TextCharacterProperties();
		}

		[XmlElement(Order = 0)]
		public CT_TextCharacterProperties rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		[XmlElement(Order = 1)]
		public CT_TextParagraphProperties pPr
		{
			get
			{
				return this.pPrField;
			}
			set
			{
				this.pPrField = value;
			}
		}

		[XmlElement(Order = 2)]
		public string t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
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

		[XmlAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}
}
