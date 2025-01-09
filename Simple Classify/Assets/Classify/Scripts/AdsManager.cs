//using UnityEngine.Advertisements;

//public class AdsManager : IUnityAdsListener
//{
//    private string gameId
//#if UNITY_IOS
//        //replace this value with your IOS game id
//     = "3988742"
//#elif UNITY_ANDROID
//        //replace this value with your Android game id
//     = "3988743"
//#endif
//        ;
//    const string VIDEO_PLACEMENT_ID = "video";
//    const string REWARDED_VIDEO_PLACEMENT_ID = "rewardedVideo";

//    private AdsManager()
//    {
//        Advertisement.AddListener(this);
//    }

//    public void Init()
//    {
//        Advertisement.Initialize(gameId);
//    }

//    /// <summary>
//    /// An event that will be fired after the rewarded ad get completed, skipped or failed
//    /// check the ShowResult to get the status
//    /// </summary>
//    public event System.Action<ShowResult> RewardedAdEnded;
//    public bool IsRewardedVideoAdReady
//    {
//        get
//        {
//            return Advertisement.IsReady(REWARDED_VIDEO_PLACEMENT_ID);
//        }
//    }
//    public bool IsVideoAdReady
//    {
//        get
//        {
//            return Advertisement.IsReady(VIDEO_PLACEMENT_ID);
//        }
//    }

//    static AdsManager instance;

//    /// <summary>
//    /// Call this function to show normal video ads (closable)
//    /// </summary>
//    /// <returns>if the add has been showed or not</returns>
//    public bool ShowVideoAd()
//    {
//        if (!IsVideoAdReady || Advertisement.isShowing) return false;
//        Advertisement.Show(VIDEO_PLACEMENT_ID);
//        return true;
//    }

//    /// <summary>
//    /// Call this function to show rewarded video ad
//    /// </summary>
//    /// <returns>if the video ad has been shown</returns>
//    public bool ShowRewardedVideoAd()
//    {
//        if (!IsRewardedVideoAdReady || Advertisement.isShowing) return false;
//        Advertisement.Show(REWARDED_VIDEO_PLACEMENT_ID);
//        return true;
//    }

//    public static AdsManager Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                instance = new AdsManager();
//            }
//            return instance;
//        }
//    }

//    public void OnUnityAdsDidError(string message)
//    {
//        RewardedAdEnded.Invoke(ShowResult.Failed);
//    }

//    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
//    {
//        if (placementId == REWARDED_VIDEO_PLACEMENT_ID)
//            RewardedAdEnded.Invoke(ShowResult.Finished);
//    }

//    public void OnUnityAdsDidStart(string placementId)
//    {

//    }

//    public void OnUnityAdsReady(string placementId)
//    {

//    }

//}
