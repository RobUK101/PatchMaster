using System;
using System.Collections.Generic;
using Microsoft.ConfigurationManagement.ManagementProvider.WqlQueryEngine;
using Microsoft.UpdateServices.Administration;
using System.Windows.Forms;
using System.Diagnostics;

namespace PatchMaster
{
    class globalObjects
    {        
        public static class GlobalClass
        {
            private static string m_globalVar0; // Build version

            private static List<string> m_globalVar1; // Popup Form Manifest
            private static List<string> m_globalVar2; // WSUS Patches
            private static string m_globalVar3; // Server Name
            private static List<string> m_globalVar4; // SCCM Collections
            private static List<string> m_globalVar5; // SUG Name Format
            private static sugitemCollection m_globalVar6; // SUG Rule List
            private static bool m_globalVar7; // Disable select Methods for startup efficiency
            private static sccmpatchCollection m_globalVar8; // SCCM Patch List (filtered)
            private static string m_globalVar9; // SCCM Site Code
            private static candidatesccmpatchCollection m_globalVar10; // Scoped SCCM Patch list
            private static List<string> m_globalVar11; // Device Type List
            private static List<string> m_globalVar12; // SUG List - Obtained from SCCM Site server during startup
            private static WqlConnectionManager m_globalVar13; // SCCM Connection Manager object
            private static patchcontentidsCollection m_globalVar14; // ContentID and CI_UniqueID stored for each Software Update Group
            private static string m_globalVar15; // UNC Path for Patch storage
            private static deploymentruleCollection m_globalVar16; // Deployment Rule Collection
            private static securityscopeCollection m_globalVar17; // Security Scope Rule Collection
            private static bool m_globalVar18; // Build thread running monitor
            private static distributionpointCollection m_globalVar19; // Distribution Point Rule Collection
            private static globaldistributionpointCollection m_globalVar20; // Distribution Point Rule Collection
            private static globalcollectionCollection m_globalVar21; // Distribution Point Rule Collection            
            private static bool m_globalVar22; // Load thread running monitor          

            // Deployment variables (stored individually and not in a class or class collection)

            private static bool m_globalVar23; // Reporting sug rollup Client 
            private static bool m_globalVar24; // Reporting sug rollup Server
            private static bool m_globalVar25; // Reporting sug rollup office 
            private static Stopwatch m_globalVar26; // Patch cache stopwatch
            private static bool m_globalVar27; // Always refresh ConfigMgr patch cache
            private static bool m_globalVar28; // Splash thread
            private static string m_globalVar29; // Patch folder path
            private static string m_globalVar30; // Patch UNC path
            private static bool m_globalVar31; // Naming bar lock status
            private static string m_globalVar32; // Naming standard
            private static bool m_globalVar33; // checkforpatches thread Running

            private static bool m_globalVar34; // deployment_allowMetered
            //private static bool m_globalVar35; // 
            private static bool m_globalVar36; // allowreportingSUGS
            private static IUpdateServer m_globalVar37; // WSUS Assembly
            private static bool m_globalVar38; // SUM Cleanup Thread Running            
            private static bool m_globalVar39; // SUM Cleanup Detect Thread Running            
            private static bool m_globalVar40; // Run SUM Cleanup Post Build        

            private static supersededpatchesCollection m_globalVar41; // superceded patch collection

            private static bool m_globalVar42; // Run SUM Cleanup Post Build

            private static deploymentpropertyCollection m_globalVar49; // Deployment Properties Collection            

            private static ruleitemCollection m_globalVar50; // Deployment Properties Collection            

            private static ignorepatchesCollection m_globalVar51; // Ignore patches collection

            private static bool m_globalVar52; // Headless mode - Silent operations - Check and Build

            private static string m_globalVar53; // OOC Tag

            private static string m_globalVar54; // Naming Delimiter

            private static string m_globalVar55; // Donwload failure retry value

            private static bool m_globalVar56; // Time machine on\off

            private static string m_globalVar57; // Time machine Year

            private static string m_globalVar58; // Time machine Month

            private static string m_globalVar59; // Time machine Day

            private static bool m_globalVar60; // Used to note whether a build out took place

            private static bool m_globalVar61; // Allow package creation

            private static string m_globalVar62; // Selected Profile

            public static string buildVersion
            {
                get { return m_globalVar0; }
                set { m_globalVar0 = value; }
            }

            public static List<string> popupformManifest
            {
                get { return m_globalVar1; }
                set { m_globalVar1 = value; }
            }

            public static List<string> wsusPatches
            {
                get { return m_globalVar2; }
                set { m_globalVar2 = value; }
            }

            public static string serverName
            {
                get { return m_globalVar3; }
                set { m_globalVar3 = value; }
            }

            public static List<string> oldsccmCollections
            {
                get { return m_globalVar4; }
                set { m_globalVar4 = value; }
            }

            public static List<string> sugnameFormat
            {
                get { return m_globalVar5; }
                set { m_globalVar5 = value; }
            }
            public static sugitemCollection globalsugItems
            {
                get { return m_globalVar6; }
                set { m_globalVar6 = value; }
            }
            public static bool disableProcessing
            {
                get { return m_globalVar7; }
                set { m_globalVar7 = value; }
            }

            public static sccmpatchCollection sccmPatches
            {
                get { return m_globalVar8; }
                set { m_globalVar8 = value; }
            }
            public static string SCCMSiteCode
            {
                get { return m_globalVar9; }
                set { m_globalVar9 = value; }
            }

            public static candidatesccmpatchCollection candidatePatches
            {
                get { return m_globalVar10; }
                set { m_globalVar10 = value; }
            }
            public static List<string> devicetypeList
            {
                get { return m_globalVar11; }
                set { m_globalVar11 = value; }
            }
            public static List<string> SCCMSUGList
            {
                get { return m_globalVar12; }
                set { m_globalVar12 = value; }
            }

            public static WqlConnectionManager ConnectionManager
            {
                get { return m_globalVar13; }
                set { m_globalVar13 = value; }
            }

            public static patchcontentidsCollection patchContentIDs
            {
                get { return m_globalVar14; }
                set { m_globalVar14 = value; }
            }

            public static string uncPath
            {
                get { return m_globalVar15; }
                set { m_globalVar15 = value; }
            }

            public static deploymentruleCollection deploymentRules
            {
                get { return m_globalVar16; }
                set { m_globalVar16 = value; }
            }

            public static securityscopeCollection securityscopeRules
            {
                get { return m_globalVar17; }
                set { m_globalVar17 = value; }
            }

            public static bool buildthreadRunning
            {
                get { return m_globalVar18; }
                set { m_globalVar18 = value; }
            }

            public static distributionpointCollection distributionpointRules
            {
                get { return m_globalVar19; }
                set { m_globalVar19 = value; }
            }

            public static globaldistributionpointCollection globaldistributionpointCollection
            {
                get { return m_globalVar20; }
                set { m_globalVar20 = value; }
            }

            public static globalcollectionCollection sccmCollections 
            {
                get { return m_globalVar21; }
                set { m_globalVar21 = value; }
            }

            public static bool loadthreadRunning
            {
                get { return m_globalVar22; }
                set { m_globalVar22 = value; }
            }

            // Deployment properties

            public static bool deployment_allowMetered
            {
                get { return m_globalVar34; }
                set { m_globalVar34 = value; }
            }
            
            public static bool allowreportingSUGS
            {
                get { return m_globalVar36; }
                set { m_globalVar36 = value; }
            }

            public static bool rollupclientOS
            {
                get { return m_globalVar23; }
                set { m_globalVar23 = value; }
            }

            public static bool rollupserverOS
            {
                get { return m_globalVar24; }
                set { m_globalVar24 = value; }
            }
            public static bool rollupoffice
            {
                get { return m_globalVar25; }
                set { m_globalVar25 = value; }
            }
            public static Stopwatch patchcacheStopwatch
            {
                get { return m_globalVar26; }
                set { m_globalVar26 = value; }
            }
            public static bool forceScan
            {
                get { return m_globalVar27; }
                set { m_globalVar27 = value; }
            }

            public static bool splashThread
            {
                get { return m_globalVar28; }
                set { m_globalVar28 = value; }
            }

            public static string patchfolderPath
            {
                get { return m_globalVar29; }
                set { m_globalVar29 = value; }
            }
            public static string patchpathUNC
            {
                get { return m_globalVar30; }
                set { m_globalVar30 = value; }
            }
            public static bool namingbarlockStatus
            {
                get { return m_globalVar31; }
                set { m_globalVar31 = value; }
            }

            public static string namingStandard
            {
                get { return m_globalVar32; }
                set { m_globalVar32 = value; }
            }
            public static bool checkforpatchesthreadRunning
            {
                get { return m_globalVar33; }
                set { m_globalVar33 = value; }
            }

            public static IUpdateServer wsusManagement
            {
                get { return m_globalVar37; }
                set { m_globalVar37 = value; }
            }

            public static bool sumcleanupthreadRunning
            {
                get { return m_globalVar38; }
                set { m_globalVar38 = value; }
            }
            public static bool sumcleanupdetectthreadRunning
            {
                get { return m_globalVar39; }
                set { m_globalVar39 = value; }
            }

            public static bool patchrunsumcleanuppostBuild
            {
                get { return m_globalVar40; }
                set { m_globalVar40 = value; }
            }

            public static supersededpatchesCollection globalsupersedpatchesCollection
            {
                get { return m_globalVar41; }
                set { m_globalVar41 = value; }
            }

            public static deploymentpropertyCollection globaldeploymentpropertiesCollection
            {
                get { return m_globalVar49; }
                set { m_globalVar49 = value; }
            }
            public static ruleitemCollection globalruleitemCollection
            {
                get { return m_globalVar50; }
                set { m_globalVar50 = value; }
            }
            public static ignorepatchesCollection globalignorepatchesCollection
            {
                get { return m_globalVar51; }
                set { m_globalVar51 = value; }
            }

            public static bool SilentRunning
            {
                get { return m_globalVar52; }
                set { m_globalVar52 = value; }
            }

            public static string oocTag
            {
                get { return m_globalVar53; }
                set { m_globalVar53 = value; }
            }
            public static string namingDelimiter
            {
                get { return m_globalVar54; }
                set { m_globalVar54 = value; }
            }

            public static string DownloadFailureRetry
            {
                get { return m_globalVar55; }
                set { m_globalVar55 = value; }
            }
            public static bool GlobalTimeMachine
            {
                get { return m_globalVar56; }
                set { m_globalVar56 = value; }
            }
            public static string GlobalTimeMachineYear
            {
                get { return m_globalVar57; }
                set { m_globalVar57 = value; }
            }
            public static string GlobalTimeMachineMonth
            {
                get { return m_globalVar58; }
                set { m_globalVar58 = value; }
            }
            public static string GlobalTimeMachineDay
            {
                get { return m_globalVar59; }
                set { m_globalVar59 = value; }
            }
            public static bool buildeventNoted
            {
                get { return m_globalVar60; }
                set { m_globalVar60 = value; }
            }

            public static bool AllowContent
            {
                get { return m_globalVar61; }
                set { m_globalVar61 = value; }
            }

            public static string SelectedProfile
            {
                get { return m_globalVar62; }
                set { m_globalVar62 = value; }
            }
        }

        // Custom Classes

        public class supersededPatch
        {
            public string SugName { get; set; }
            public string SugCIID { get; set; }
            public string PatchCIID { get; set; }
            public string ArticleID{ get; set; }
            public string LocalizedDisplayName { get; set; }            
        }

        public class supersededpatchesCollection : System.Collections.CollectionBase
        {
            public void Add(supersededPatch asupersededPatch)
            {
                List.Add(asupersededPatch);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void RemoveName(string sugName)
            {
                if (sugName != "")
                {
                    foreach (supersededPatch asupersededPatch in List)
                    {
                        if (asupersededPatch.SugName == sugName)
                        {
                            List.Remove(asupersededPatch);
                            break;
                        }
                    }
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public supersededPatch Item(int Index)
            {
                return (supersededPatch)List[Index];
            }
        }


        public class supdpItem
        {
            public string PackageID { get; set; }
            public string Name { get; set; }
        }
        public class supdpitemCollection : System.Collections.CollectionBase
        {
            public void Add(supdpItem asupdpItem)
            {
                List.Add(asupdpItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void RemoveName(string theName)
            {
                if (theName != "")
                {
                    foreach (supdpItem asupdpItem in List)
                    {
                        if (asupdpItem.Name == theName)
                        {
                            List.Remove(asupdpItem);
                            break;
                        }
                    }
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public supdpItem Item(int Index)
            {
                return (supdpItem)List[Index];
            }
        }
        public class deploymentProperty
        {
            public string DeviceGroup { get; set; }
            public bool DisableMomAlerts { get; set; }
            public int DPLocality { get; set; }
            public bool LimitStateMessageVerbosity { get; set; }
            public bool LogComplianceToWinEvent { get; set; }
            public bool NotifyUser { get; set; }
            public bool OverrideServiceWindows { get; set; }
            public bool PersistOnWriteFilterDevices { get; set; }
            public bool RaiseMomAlertsOnFailure { get; set; }
            public bool RebootOutsideOfServiceWindows { get; set; }
            public bool RequirePostRebootFullScan { get; set; }
            public bool SendDetailedNonComplianceStatus { get; set; }
            public bool SoftDeadlineEnabled { get; set; }
            public string StateMessagePriority { get; set; }
            public string StateMessageVerbosity { get; set; }
            public int SuppressReboot { get; set; }
            public bool UseBranchCache { get; set; }
            public bool UseGMTTimes { get; set; }
            public bool UserUIExperience { get; set; }
            public bool WoLEnabled { get; set; }
            public bool RandomizationEnabled { get; set; }
        }

        public class deploymentpropertyCollection : System.Collections.CollectionBase
        {
            public void Add(deploymentProperty adeploymentProperty)
            {
                List.Add(adeploymentProperty);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void RemoveName(string theName)
            {
                if (theName != "")
                {
                    foreach (deploymentProperty adeploymentProperty in List)
                    {
                        if (adeploymentProperty.DeviceGroup == theName)
                        {
                            List.Remove(adeploymentProperty);
                            break;
                        }
                    }
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public deploymentProperty Item(int Index)
            {
                return (deploymentProperty)List[Index];
            }
        }
        public class patchcontentIDs
        {
            public int ContentID { get; set; }
            public string ContentUniqueID { get; set; }
            public string CI_UniqueID { get; set; }
        }
        public class patchcontentidsCollection : System.Collections.CollectionBase
        {
            public void Add(patchcontentIDs apatchcontentIDs)
            {
                List.Add(apatchcontentIDs);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public patchcontentIDs Item(int Index)
            {
                return (patchcontentIDs)List[Index];
            }
        }
        public class candidatesccmPatch
        {
            public string ArticleID { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime DateLastModified { get; set; }
            public DateTime DatePosted { get; set; }
            public DateTime DateRevised { get; set; }
            public List<string> LocalizedCategoryInstanceNames { get; set; }
            public string LocalizedDisplayName { get; set; }
            public List<string> UpdateLocales { get; set; }
            public string Product { get; set; }
            public string Classification { get; set; }
            public string Architecture { get; set; }
            public int CI_ID { get; set; }
            public string CI_UniqueID { get; set; }
        }        

        public class candidatesccmpatchCollection : System.Collections.CollectionBase
        {
            public void Add(candidatesccmPatch asccmPatch)
            {
                List.Add(asccmPatch);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public candidatesccmPatch Item(int Index)
            {
                return (candidatesccmPatch)List[Index];
            }
        }
        public class sccmPatch
        {
            public string ArticleID { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime DateLastModified { get; set; }
            public DateTime DatePosted { get; set; }
            public DateTime DateRevised { get; set; }
            public List<string> LocalizedCategoryInstanceNames { get; set; }            
            public string LocalizedDisplayName { get; set; }
            public List<string> UpdateLocales { get; set; }
            public int CI_ID { get; set; }
            public string CI_UniqueID { get; set; }
        }

        public class sccmpatchCollection : System.Collections.CollectionBase
        {
            public void Add(sccmPatch asccmPatch)
            {
                List.Add(asccmPatch);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public sccmPatch Item(int Index)
            {
                return (sccmPatch)List[Index];
            }
        }

        public class globalcollectionItem
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string ID { get; set; }
        }

        public class globalcollectionCollection : System.Collections.CollectionBase
        {
            public void Add(globalcollectionItem aglobalcollectionItem)
            {
                List.Add(aglobalcollectionItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public globalcollectionItem Item(int Index)
            {
                return (globalcollectionItem)List[Index];
            }

            public bool Contains(globalcollectionCollection supplieddpItem)
            {
                return false;
            }
        }

        public class globaldistributionpointItem
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string NALPath { get; set; }
            public string Sitecode { get; set; }
        }

        public class globaldistributionpointCollection : System.Collections.CollectionBase
        {
            public void Add(globaldistributionpointItem AglobaldistributionpointItem)
            {
                List.Add(AglobaldistributionpointItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public globaldistributionpointItem Item(int Index)
            {
                return (globaldistributionpointItem)List[Index];
            }

            public bool Contains(globaldistributionpointCollection supplieddpItem)
            {
                return false;
            }
        }

        public class distributionpointItem
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string ID { get; set; }
            public string NALPath { get; set; }
            public string Sitecode { get; set; }
        }

        public class ignorepatchesCollection : System.Collections.CollectionBase
        {
            public void Add(ignorepatchesItem aignorepatchesItem)
            {
                List.Add(aignorepatchesItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public ignorepatchesItem Item(int Index)
            {
                return (ignorepatchesItem)List[Index];
            }

            public bool Contains(ignorepatchesItem suppliedignorepatchesItem, List<string> LocalizedCategoryInstanceNames)
            {
                foreach (ignorepatchesItem aignorepatchesItem in List)
                {
                    if (suppliedignorepatchesItem.PatchKB == aignorepatchesItem.PatchKB && suppliedignorepatchesItem.DisplayName == aignorepatchesItem.DisplayName && LocalizedCategoryInstanceNames.Contains(aignorepatchesItem.Product))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public class ignorepatchesItem
        {
            public string PatchKB { get; set; }
            public string DisplayName { get; set; }
            public string Product { get; set; }
            public string Classification { get; set; }
        }

        public class distributionpointCollection : System.Collections.CollectionBase
        {
            public void Add(distributionpointItem adistributionpointItem)
            {
                List.Add(adistributionpointItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public distributionpointItem Item(int Index)
            {
                return (distributionpointItem)List[Index];
            }

            public bool Contains(distributionpointCollection supplieddpItem)
            {
                return false;
            }
        }

        public class securityscopeItem
        {
            public string DeviceGroup { get; set; }
            public string ScopeType { get; set; }
            public string Scope { get; set; }            
        }

        public class securityscopeCollection : System.Collections.CollectionBase
        {
            public void Add(securityscopeItem asecurityscopeItem)
            {
                List.Add(asecurityscopeItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public securityscopeItem Item(int Index)
            {
                return (securityscopeItem)List[Index];
            }

            public bool Contains(securityscopeCollection suppliedloggingItem)
            {
                foreach (securityscopeCollection aloggingItem in List)
                {
                }

                return false;
            }
        }
        public class deploymentItem
        {
            public string DeviceType{ get; set; }
            public string TargetCollection { get; set; }
            public string DeploymentTag { get; set; }
            public string Intent { get; set; }
            public string AvailDaysOffset { get; set; }
            public string AvailTimeOffset { get; set; }
            public string DeadlineDaysOffset { get; set; }            
            public string DeadlineTimeOffset { get; set; }
        }

        public class deploymentruleCollection : System.Collections.CollectionBase
        {
            public void Add(deploymentItem adeploymentItem)
            {
                List.Add(adeploymentItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public deploymentItem Item(int Index)
            {
                return (deploymentItem)List[Index];
            }

            public bool Contains(deploymentruleCollection suppliedloggingItem)
            {
                foreach (deploymentruleCollection aloggingItem in List)
                {                
                }

                return false;
            }
        }

        public class ruleItem
        {
            public string DeviceType { get; set; }
            public string Architectures { get; set; }
            public string Products { get; set; }
            public string Classifications { get; set; }
            public string Languages { get; set; }
            public string IncludeRule { get; set; }
            public string ExcludeRule { get; set; }          
        }
        public class ruleitemCollection : System.Collections.CollectionBase
        {
            public void Add(ruleItem aruleItem)
            {
                List.Add(aruleItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public ruleItem Item(int Index)
            {
                return (ruleItem)List[Index];
            }

            public bool Contains(ruleitemCollection suppliedloggingItem)
            {
                //foreach (ruleCollection aloggingItem in List)
                //{
                //    //if (aloggingItem.deviceName == suppliedloggingItem.deviceName && aloggingItem.loggingType == suppliedloggingItem.loggingType)
                //    //{
                //    //    return true;
                //    //}
                //}

                return false;
            }
        }

        public class sugItem
        {
            public string sugName { get; set; }
            public List<string> Products { get; set; }
            public List<string> Classifications { get; set; }
            public List<string> Architectures { get; set; }                        
            public Int16 TotalPatches { get; set; }
            public string DeviceType { get; set; }
            public string Languages { get; set; }
            public string SUGType { get; set; }
        }

        public class sugitemCollection : System.Collections.CollectionBase
        {
            public void Add(sugItem aruleItem)
            {
                List.Add(aruleItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public sugItem Item(int Index)
            {
                return (sugItem)List[Index];
            }            
        }

        public class sumcleanupthreadItem
        {
            public bool runcleanupThread { get; set; }
            public DataGridViewRowCollection RowCollection { get; set; }
        }
    }    
}