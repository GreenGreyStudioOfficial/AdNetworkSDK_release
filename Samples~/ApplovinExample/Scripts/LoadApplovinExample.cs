using System;
using System.Collections.Generic;
using GGADSDK.Samples.ApplovinExample.Scripts.Connectors.Applovin;
using GreenGrey.AdNetworkSDK;
using GreenGrey.AdNetworkSDK.DataModel;
using GreenGrey.AdNetworkSDK.DataModel.Enums;
using GreenGrey.AdNetworkSDK.Interfaces.Connector;
using GreenGrey.AdNetworkSDK.Interfaces.Listeners.Initialization;
using GreenGrey.AdNetworkSDK.Interfaces.Listeners.Load;
using GreenGrey.AdNetworkSDK.Interfaces.Listeners.Show;
using UnityEngine;
using UnityEngine.UI;

namespace GGADSDK.Samples.ApplovinExample.Scripts
{
    public class LoadApplovinExample : MonoBehaviour, IAdInitializationListener, IAdLoadListener, IAdShowListener
    {
        [Header("Applovin")] 
        [SerializeField] private string m_sdkKey;
        [SerializeField] private string m_userId;
        [SerializeField] private string m_interstitialAdUnitId;
        [SerializeField] private string m_rewardAdUnitId;
        [SerializeField] private string m_bannerAdUnitId;
        [SerializeField] private string m_mrecAdUnitId;
        [Header("UI")]
        [SerializeField] private Toggle m_interstitialToggle;
        [SerializeField] private Toggle m_rewardToggle;
        [SerializeField] private Toggle m_bannerToggle;
        [SerializeField] private Toggle m_mrecToggle;
        [SerializeField] private Button m_initButton;
        [SerializeField] private Button m_loadButton;
        [SerializeField] private Button m_showButton;
        
        void Start()
        {
            m_initButton.onClick.AddListener(OnInitializeClicked);
            m_loadButton.onClick.AddListener(OnLoadClicked);
            m_showButton.onClick.AddListener(OnShowClicked);
        }

        /// <summary>
        /// Initialize click handler
        /// </summary>
        private void OnInitializeClicked()
        {
            AdNetworkSDK.Initialize(
                new AdNetworkInitParams(
                    "secret_204",
                    true,
                    false,
                    new List<AdType>()),
                this,
                new ISdkConnector[] { new ApplovinConnector(m_sdkKey, m_userId) });
        }

        /// <summary>
        /// Load click handler
        /// </summary>
        private void OnLoadClicked()
        {
            AdNetworkSDK.Load(GetAdType(), this, GetPlacementId());
        }

        /// <summary>
        /// Show click handler
        /// </summary>
        private void OnShowClicked()
        {
            AdNetworkSDK.Show(GetAdType(), this, GetPlacementId());
        }

        /// <summary>
        /// Get AdType by using toggles 
        /// </summary>
        /// <returns>Selected AdType</returns>
        /// <exception cref="ArgumentException">Unknown AdType</exception>
        private AdType GetAdType()
        {
            if (m_interstitialToggle.isOn)
                return AdType.INTERSTITIAL;
            if (m_rewardToggle.isOn)
                return AdType.REWARDED;
            if (m_bannerToggle.isOn)
                return AdType.BANNER;
            if (m_mrecToggle.isOn)
                return AdType.MREC;
            
            throw new ArgumentException();
        }

        /// <summary>
        /// Get PlacementId by using toggles
        /// </summary>
        /// <returns>Selected PlacementId</returns>
        /// <exception cref="ArgumentException">Unknown PlacementId</exception>
        private string GetPlacementId()
        {
            if (m_interstitialToggle.isOn)
                return m_interstitialAdUnitId;
            if (m_rewardToggle.isOn)
                return m_rewardAdUnitId;
            if (m_bannerToggle.isOn)
                return m_bannerAdUnitId;
            if (m_mrecToggle.isOn)
                return m_mrecAdUnitId;
            
            throw new ArgumentException();
        }

        /// <summary>
        /// Initialize success complete handler
        /// </summary>
        public void OnInitializationComplete()
        {
            Debug.Log("Initialize complete");
        }

        /// <summary>
        /// Initialize error complete handler
        /// </summary>
        /// <param name="_error">Error type</param>
        /// <param name="_errorMessage">Error message</param>
        public void OnInitializationError(InitializationErrorType _error, string _errorMessage)
        {
            Debug.Log($"InitializeError:\n{_errorMessage}");
        }

        /// <summary>
        /// Initialize with warning complete handler
        /// </summary>
        /// <param name="_warningType">Warning type</param>
        /// <param name="_warningMessage">Warning message</param>
        public void OnInitializationWarning(InitializationWarningType _warningType, string _warningMessage)
        {
            Debug.Log($"Warning: {_warningType.ToString()}. {_warningMessage}");
        }

        /// <summary>
        /// Load success complete handler
        /// </summary>
        /// <param name="_adType">Loaded creative type</param>
        public void OnLoadComplete(AdType _adType)
        {
            Debug.Log($"Load {_adType} complete");
        }

        /// <summary>
        /// Load error complete handler
        /// </summary>
        /// <param name="_adType">Creative type</param>
        /// <param name="_error">Error type</param>
        /// <param name="_errorMessage">Error message</param>
        public void OnLoadError(AdType _adType, LoadErrorType _error, string _errorMessage)
        {
            Debug.Log($"Load {_adType} complete with error {_errorMessage}");
        }

        /// <summary>
        /// Show start handler
        /// </summary>
        /// <param name="_adType">Showed creative type</param>
        public void OnShowStart(AdType _adType)
        {
            Debug.Log($"Show {_adType} start");
        }

        /// <summary>
        /// Show complete handler
        /// </summary>
        /// <param name="_adType">Creative type</param>
        /// <param name="_showCompletionState">Complete status. Skipped or closed</param>
        /// <param name="_validationId">Id for validation creative show status. Can be null</param>
        public void OnShowComplete(AdType _adType, ShowCompletionState _showCompletionState, string _validationId)
        {
            Debug.Log($"Show {_adType} complete");
        }

        /// <summary>
        /// Show error handler
        /// </summary>
        /// <param name="_adType">Creative type</param>
        /// <param name="_error">Error type</param>
        /// <param name="_errorMessage">Error message</param>
        public void OnShowError(AdType _adType, ShowErrorType _error, string _errorMessage)
        {
            Debug.Log($"Show {_adType} complete with error {_errorMessage}");
        }
    }
}
