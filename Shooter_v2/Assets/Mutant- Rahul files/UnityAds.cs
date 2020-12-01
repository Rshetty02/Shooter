using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour , IUnityAdsListener
{

    string GooglePlayId = "3921509";

    int bonus;

    string myPlacementId = "rewardedVideo";

    bool GameMode = false;//testmode
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener (this);
        Advertisement.Initialize(GooglePlayId,GameMode);
        //DisplayInterstitialAD();
    }

    public void DisplayInterstitialAD(){
        Advertisement.Show();
        
    }

    public void DisplayVideoAD(){
        Advertisement.Show(myPlacementId);
    }

    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            // Reward the user for watching the ad to completion.
            Debug.LogWarning("You Get a reward!");
            bonus = PlayerPrefs.GetInt("HighScore") + 20;
            PlayerPrefs.SetInt("HighScore",bonus);

        } else if (showResult == ShowResult.Skipped) {
            // Do not reward the user for skipping the ad.
            Debug.LogWarning("You don't get a reward!");
        } else if (showResult == ShowResult.Failed) {
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady (string placementId) {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId) {
            // Optional actions to take when the placement becomes ready(For example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string placementId) {
        // Optional actions to take when the end-users triggers an ad.
    } 

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy() {
        Advertisement.RemoveListener(this);
    }
    
    
}
