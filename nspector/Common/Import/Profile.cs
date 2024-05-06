using System;
using System.Collections.Generic;

namespace nspector.Common.Import
{
    [Serializable]
    public class Profile
    {
        public string ProfileName = "";
        public List<string> Executeables = [];
        public List<ProfileSetting> Settings = [];
    }
}