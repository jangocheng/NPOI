﻿//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using Npoi.Core.OpenXml4Net.Exceptions;
//using Npoi.Core.OpenXml4Net.OPC.Internal;
//using Npoi.Core.Util;

//namespace Npoi.Core.OpenXml4Net.OPC
//{
//    /**
//     * @deprecated (name clash with {@link java.lang.Package} use {@link OPCPackage} instead.
//     * 
//     * @author Julien Chable, CDubet
//     * 
//     */
//    public abstract class Package : OPCPackage
//    {

//        /**
//         * Logger.
//         */
//        private static POILogger logger = POILogFactory.GetLogger(typeof(Package));


//        /**
//         * @deprecated use {@link OPCPackage} 
//         */
//        public Package(PackageAccess access)
//            : base(access)
//        {

//        }


//        /**
//         * @deprecated use {@link OPCPackage#open(String)} 
//         */
//        public static Package Open(String path)
//        {
//            return Open(path, defaultPackageAccess);
//        }

//        /**
//         * @deprecated use {@link OPCPackage#open(String,PackageAccess)} 
//         */
//        public static Package Open(String path, PackageAccess access)
//        {
//            if (path == null || "".Equals(path.Trim())
//                    || new DirectoryInfo(path).Exists)
//                throw new ArgumentException("path");

//            Package pack = new ZipPackage(path, access);
//            if (pack.partList == null && access != PackageAccess.WRITE)
//            {
//                pack.GetParts();
//            }
//            pack.originalPackagePath = Path.GetFullPath(path);
//            return pack;
//        }

//        /**
//         * @deprecated use {@link OPCPackage#open(InputStream)} 
//         */
//        public static Package Open(Stream in1)
//        {
//            Package pack = new ZipPackage(in1, PackageAccess.READ);
//            if (pack.partList == null)
//            {
//                pack.GetParts();
//            }
//            return pack;
//        }

//        /**
//         * @deprecated use {@link OPCPackage#openOrCreate(java.io.File)}  
//         */
//        public static Package OpenOrCreate(string path)
//        {
//            Package retPackage = null;
//            if (File.Exists(path))
//            {
//                retPackage = Open(path);
//            }
//            else
//            {
//                retPackage = Create(path);
//            }
//            return retPackage;
//        }

//        public static Package Create()
//        {
//            Stream memStream = new MemoryStream();
//            return Package.Create(memStream);
//        }
//        /**
//         * @deprecated use {@link OPCPackage#create(File)} 
//         */
//        public static Package Create(string path)
//        {
//            if (new DirectoryInfo(path).Exists)
//                throw new ArgumentException("path");

//            if (File.Exists(path))
//            {
//                throw new InvalidOperationException(
//                        "This package (or file) already exists : use the open() method or delete the file.");
//            }

//            // Creates a new package
//            Package pkg = null;
//            pkg = new ZipPackage();
//            pkg.originalPackagePath = Path.GetFullPath(path);

//            ConfigurePackage(pkg);
//            return pkg;
//        }

//        /**
//         * @deprecated use {@link OPCPackage#create(OutputStream)} 
//         */
//        public static Package Create(Stream output)
//        {
//            Package pkg = null;
//            pkg = new ZipPackage();
//            pkg.originalPackagePath = null;
//            pkg.output = output;

//            ConfigurePackage(pkg);
//            return pkg;
//        }

//        /**
//         * Configure the package.
//         * 
//         * @param pkg
//         */
//        private static void ConfigurePackage(Package pkg)
//        {
//                // Content type manager
//                pkg.contentTypeManager = new ZipContentTypeManager(null, pkg);
//                // Add default content types for .xml and .rels
//                pkg.contentTypeManager
//                        .AddContentType(
//                                PackagingUriHelper
//                                        .CreatePartName(PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_URI),
//                                ContentTypes.RELATIONSHIPS_PART);
//                pkg.contentTypeManager
//                        .AddContentType(PackagingUriHelper
//                                .CreatePartName("/default.xml"),
//                                ContentTypes.PLAIN_OLD_XML);

//                // Init some Package properties
//                pkg.packageProperties = new PackagePropertiesPart(pkg,
//                        PackagingUriHelper.CORE_PROPERTIES_PART_NAME);
//                pkg.packageProperties.SetCreatorProperty("Generated by OpenXml4Net");
//                pkg.packageProperties.SetCreatedProperty(new Nullable<DateTime>(
//                        new DateTime()));
            
//        }

//    }
//}