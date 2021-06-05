﻿using DbViewer.Shared.Configuration;
using System.Collections.Generic;

namespace DbViewer.Hub.Services
{
    public interface IHubService
    {
        public HubInfo GetLatestHub();

        public void SaveLatestHub(HubInfo hubInfo);

        public List<IDbScanner> GetAllDbScanners();
    }
}
