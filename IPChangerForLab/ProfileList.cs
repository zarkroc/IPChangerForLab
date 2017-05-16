using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPChangerForLab
{
    class ProfileList
    {
        private List<NicProfile> nicProfiles;

        internal List<NicProfile> NicProfiles { get => nicProfiles; set => nicProfiles = value; }

        public ProfileList()
        {
            nicProfiles = new List<NicProfile>();
        }

        internal void AddProfile(NicProfile profile)
        {
            NicProfiles.Add(profile);
        }

        
    }
}
