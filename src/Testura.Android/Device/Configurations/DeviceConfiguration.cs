﻿using System.IO;
using System.Reflection;
using Testura.Android.Util;
using Testura.Android.Util.Extensions;

namespace Testura.Android.Device.Configurations
{
    public class DeviceConfiguration
    {
        public const string UiAutomatorStub = "uiautomator-stub.jar";
        public const string UiAutomatorStubBundle = "uiautomator-stub-bundle.jar";
        public const string HelperApkName = "testura-helper.apk";

        public DeviceConfiguration()
        {
            AdbPath = string.Empty;
            Serial = string.Empty;
            Dependencies = DependencyHandling.InstallIfMissing;
            DependenciesDirectory = Path.Combine(Assembly.GetExecutingAssembly().GetDirectoryPath(), "Dependencies");
            Port = 9008;
            DumpTries = 5;
        }

        /// <summary>
        /// Gets or sets the path to adb.exe
        /// </summary>
        public string AdbPath { get; set; }

        /// <summary>
        /// Gets or sets the serial of device under test.
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we should push and install
        /// all required dependencies.
        /// </summary>
        public DependencyHandling Dependencies { get; set; }

        /// <summary>
        /// Gets or sets the directory to all dependencies (uiautomator stub, helper apk, etc)
        /// </summary>
        public string DependenciesDirectory { get; set; }

        /// <summary>
        /// Gets or sets the local port to the device
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets how many times we should try to dump the UI before
        /// sending exception.
        /// </summary>
        public int DumpTries { get; set; }
    }
}
