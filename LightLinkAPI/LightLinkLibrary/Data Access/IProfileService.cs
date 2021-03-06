﻿using LightLinkModels;
using System.Collections.Generic;

namespace LightLinkLibrary.Data_Access
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfilesForUser(string username);
        void AddProfileToUser(string username, Profile dto);
        void RemoveProfileFromUser(string username, string name);
        void UpdateProfileOnUser(string username, string name, Profile dto);
        bool Exists(string username, string name);
        Profile GetActiveForUser(string username);
        void SetActiveForUser(string username, Profile dto);
    }
}
