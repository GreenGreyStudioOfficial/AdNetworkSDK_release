using GreenGrey.AdNetworkSDK;
using GreenGrey.AdNetworkSDK.DataModel.Enums;
using GreenGrey.AdNetworkSDK.Interfaces.Listeners;
using UnityEngine;
using UnityEngine.UI;

namespace GGADSDK.Samples.LazyLoadExample.Scripts
{
    public class LazyLoadExampleListener : MonoBehaviour, IAdInitializationListener, IAdLoadListener, IAdShowListener
    {
        private const string MY_GAME_ID = "MY_GAME_ID";
        private const string AD_SERVER_HOST = "AD_SERVER_HOST";
        
        [SerializeField] private Button m_initButton;
        [SerializeField] private Button m_loadButton;
        [SerializeField] private Button m_showButton;

        private string m_loadedId;
        
        #region MonoBehaviour

        private void Start()
        {
            m_initButton.onClick.AddListener(InitButtonAction);
            m_loadButton.onClick.AddListener(LoadButtonAction);
            m_showButton.onClick.AddListener(ShowButtonAction);
        }

        private void InitButtonAction()
        {
            Debug.Log("Initialisation started");
            AdNetworkSDK.Initialize(MY_GAME_ID, AD_SERVER_HOST, true, this);
        }

        private void LoadButtonAction()
        {
            Debug.Log("LazyLoad started");
            AdNetworkSDK.LazyLoad(AdType.REWARDED, this);
        }
        
        private void ShowButtonAction()
        {
            Debug.Log($"Start showing with id: [{m_loadedId}]");
            AdNetworkSDK.Show(m_loadedId, this);
        }

        #endregion

        #region IAdInitializationListener

        public void OnInitializationComplete()
        {
            Debug.Log("Initialization: SUCCESS!");
        }

        public void OnInitializationError(InitializationErrorType _error, string _errorMessage)
        {
            Debug.LogError($"Initialization failed with error [{_error}]: {_errorMessage}");
        }

        #endregion

        #region IAdLoadListener

        public void OnLoadComplete(string _id)
        {
            m_loadedId = _id;
            Debug.Log($"LazyLoad [{_id}]: SUCCESS");
        }
        
        public void OnLoadError(LoadErrorType _error, string _id, string _errorMessage)
        {
            Debug.LogError($"LazyLoad [{_id}]: failed with error [{_error}]: {_errorMessage}");
        }

        #endregion

        #region IAdShowListener
        
        public void OnShowStart(string _id)
        {
            Debug.Log($"Show [{_id}]: Show started");
        }

        public void OnShowComplete(string _id, ShowCompletionState _showCompletionState)
        {
            Debug.Log($"Show [{_id}]: Show completed with [{_showCompletionState}] complete state");
        }

        public void OnShowError(string _id, ShowErrorType _error, string _errorMessage)
        {
            Debug.LogError($"Show [{_id}]: failed with error [{_error}]: {_errorMessage}");
        }
        
        #endregion
    }
}
