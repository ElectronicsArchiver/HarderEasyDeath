﻿using System.Collections.Generic;
using UnityEngine;
// ReSharper disable All

namespace HarderEasyDeath
{
    public class SettingsAPI
    {
        
        // This variable is automatically changed.
        public static bool ExtraSettingsAPI_Loaded = false; // This is set to true while the mod's settings are loaded
        
        public void ExtraSettingsAPI_Load() // Occurs when the API loads the mod's settings
        {
        }

        public void ExtraSettingsAPI_Unload() // Occurs when the API unloads
        {
        }

        public void ExtraSettingsAPI_SettingsOpen() // Occurs when user opens the settings menu
        {
        }

        public void ExtraSettingsAPI_SettingsClose() // Occurs when user closes the settings menu
        {
        }

        public void ExtraSettingsAPI_SettingsCreate() // Occurs when API creates the controls for the settings of this mod. This event still occurs but is now obsolete, use the SettingsOpen event instead
        {
        }

        public void ExtraSettingsAPI_ButtonPress(string name) // Occurs when a settings button is clicked. "name" is set the the button's name
        {
        }
        
        /*
         =================================================
         | Use the following methods to get/set the values of
         | the settings. These functions will throw Exceptions
         | if either the specified name is wrong or the
         | setting does not exist. These functions will only
         | allow you to get the settings that belong to your
         | mod. This means you don't need to worry about mod
         | conflicts in the settings. You also don't need to
         | put contents for any of these methods, the API will
         | handle that for you.
         =================================================
        */

        /*
         =================================================
         | These methods can be don't have to be static or can
         | have a first parameter of type Mod (or one of its
         | derived types). Note: it cannot be both non-static
         | and have the extra first parameter. You can also
         | change the name of the parameters to anything you
         | want.
         =================================================
        */

        // Use to get the selected index from a Combobox type setting
        public static int ExtraSettingsAPI_GetComboboxSelectedIndex(string SettingName) => -1;

        // Use to get the selected item name from a Combobox type setting
        public static string ExtraSettingsAPI_GetComboboxSelectedItem(string SettingName) => "";

        // Use to get the list of items in a Combobox type setting
        public static string[] ExtraSettingsAPI_GetComboboxContent(string SettingName) => new string[0];

        // Use to get the current state of a Checkbox type setting
        public static bool ExtraSettingsAPI_GetCheckboxState(string SettingName) => false;

        // Use to get the current value from a Slider type setting
        // This method returns the value of the slider rounded according to the mod's setting configuration
        public static float ExtraSettingsAPI_GetSliderValue(string SettingName) => 0;

        // Use to get the current value from a Slider type setting
        // This method returns the non-rounded value of the slider
        public static float ExtraSettingsAPI_GetSliderRealValue(string SettingName) => 0;

        // Use to get the keybind name for a Keybind type setting
        // The returned name can be used with the MyInput functions to detect keypresses
        public static string ExtraSettingsAPI_GetKeybindName(string SettingName) => "";

        // Use to get the raw keybind for a Keybind type setting
        public static Keybind ExtraSettingsAPI_GetKeybind(string SettingName) => null;

        // Use to get the main key for a Keybind type setting
        public static KeyCode ExtraSettingsAPI_GetKeybindMain(string SettingName) => KeyCode.None; // can also be named: ExtraSettingsAPI_GetKeybind_main

        // Use to get the alternate key for a Keybind type setting
        public static KeyCode ExtraSettingsAPI_GetKeybindAlt(string SettingName) => KeyCode.None; // can also be named: ExtraSettingsAPI_GetKeybind_alt

        // Use to get the input value from a Input type setting
        public static string ExtraSettingsAPI_GetInputValue(string SettingName) => "";

        // Use to get the value of an item inside a Data type setting
        // If no item with the specified subname exists it will return an empty string
        public static string ExtraSettingsAPI_GetDataValue(string SettingName, string subname) => "";

        // Use to get the subnames of all the items inside a Data type setting
        public static string[] ExtraSettingsAPI_GetDataNames(string SettingName) => new string[0];

        // Use to get the text label of a setting
        public static string ExtraSettingsAPI_GetText(string SettingName) => ""; // can also be named: ExtraSettingsAPI_GetSettingText, ExtraSettingsAPI_GetSettingsText 

        // Use to set the selected index in a Combobox type setting
        public static void ExtraSettingsAPI_SetComboboxSelectedIndex(string SettingName, int value) { }

        // Use to set the selected item in a Combobox type setting
        public static void ExtraSettingsAPI_SetComboboxSelectedItem(string SettingName, string value) { }

        // Use to set the items listed in a Combobox type setting
        public static void ExtraSettingsAPI_SetComboboxContent(string SettingName, string[] value) { }

        // Use to add an item to the items listed in a Combobox type setting
        public static void ExtraSettingsAPI_AddComboboxContent(string SettingName, string value) { }

        // Use to reset items listed in a Combobox type setting to the list set in the mod json
        public static void ExtraSettingsAPI_ResetComboboxContent(string SettingName) { }

        // Use to set the current state of a Checkbox type setting
        public static void ExtraSettingsAPI_SetCheckboxState(string SettingName, bool value) { }

        // Use to set the value of a Slider type setting
        public static void ExtraSettingsAPI_SetSliderValue(string SettingName, float value) { }

        // Use to set the current main keybinding for a Keybind type setting
        public static void ExtraSettingsAPI_SetKeybindMain(string SettingName, KeyCode value) { } // can also be named: ExtraSettingsAPI_SetKeybind_main

        // Use to set the current alternative keybinding for a Keybind type setting
        public static void ExtraSettingsAPI_SetKeybindAlt(string SettingName, KeyCode value) { } // can also be named: ExtraSettingsAPI_SetKeybind_alt

        // Use to set the value of a Input type setting
        public static void ExtraSettingsAPI_SetInputValue(string SettingName, string value) { }

        // Use to set the value of an item inside a Data type setting
        // If no item with the specified subname exists, a new item will be created with the specified value
        public static void ExtraSettingsAPI_SetDataValue(string SettingName, string subname, string value) { }

        // Use to set the values of a Data type setting
        // This completely replaces the contents of the setting
        public static void ExtraSettingsAPI_SetDataValues(string SettingName, Dictionary<string, string> values) { }

        // Use to set the text label of a setting
        // This change is not stored in the save data
        public static void ExtraSettingsAPI_SetText(string SettingName, string value) { } // can also be named: ExtraSettingsAPI_SetSettingText, ExtraSettingsAPI_SetSettingsText

        // Use to reset a setting to its default value
        public static void ExtraSettingsAPI_ResetSetting(string SettingName) { }

        // Use to reset all settings to their default values
        public static void ExtraSettingsAPI_ResetAllSettings() { } // can also be named: ExtraSettingsAPI_ResetSettings
    }
}