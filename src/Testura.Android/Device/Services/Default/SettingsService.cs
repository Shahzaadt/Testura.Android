﻿using Testura.Android.Util;
using Testura.Android.Util.Logging;

namespace Testura.Android.Device.Services.Default
{
    public class SettingsService : Service, ISettingsService
    {
        /// <summary>
        /// Enable or disable wifi
        /// </summary>
        /// <param name="state">Wanted state of wifi</param>
        public void Wifi(State state)
        {
            DeviceLogger.Log("Changing wifi state");
            Device.Adb.Shell(state == State.Enable
                ? "am startservice -n com.testura.helper/.service.setting.WifiService -e enable 1"
                : "am startservice -n com.testura.helper/.service.setting.WifiService -e enable 0");
        }

        /// <summary>
        /// Enable or disable gps
        /// </summary>
        /// <param name="state">Wanted state of gps</param>
        public void Gps(State state)
        {
            DeviceLogger.Log("Changing gps state");
            if (state == State.Enable)
            {
                Device.Adb.Shell("settings put secure location_providers_allowed +gps");
                Device.Adb.Shell("settings put secure location_providers_allowed +network");
                Device.Adb.Shell("settings put secure location_providers_allowed +wifi");
            }
            else
            {
                Device.Adb.Shell("settings put secure location_providers_allowed -gps");
                Device.Adb.Shell("settings put secure location_providers_allowed -network");
                Device.Adb.Shell("settings put secure location_providers_allowed -wifi");
            }
        }

        /// <summary>
        /// Enable or disable airplane mode
        /// </summary>
        /// <param name="state">Wanted state of airplane mode</param>
        public void AirplaneMode(State state)
        {
            DeviceLogger.Log("Changing airplane mode state");
            Device.Adb.Shell(state == State.Enable
                ? "settings put global airplane_mode_on 1"
                : "settings put global airplane_mode_on 0");

            Device.Adb.Shell("am broadcast -a android.intent.action.AIRPLANE_MODE");
        }
    }
}
