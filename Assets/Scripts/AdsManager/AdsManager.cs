using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using TMPro;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] private Button rewardButton = null;

    private string googlePlayID = "4010725";
    private bool gameMode = false;
    private string mySurfacingId = "rewardedVideo";

    private int videoCount = 0;

    private void Start() {
        Advertisement.AddListener(this);
        Advertisement.Initialize(googlePlayID, gameMode);
    }

    public void DisplayAds() {
        Advertisement.Show();
    }

    public void ShowRewardedVideo() {
        // Check if UnityAds ready before calling Show method:
        Advertisement.Show(mySurfacingId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            GetReward();
        } else if (showResult == ShowResult.Skipped) {
            // Do not reward the user for skipping the ad.
            Debug.Log("Video Skipped");
            rewardButton.interactable = false;
        } else if (showResult == ShowResult.Failed) {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string surfacingId) {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == mySurfacingId) {
            
        }
    }

    public void OnUnityAdsDidError(string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string surfacingId) {
        // Optional actions to take when the end-users triggers an ad.
    }

    private void GetReward() {
        if(videoCount == 0) {
            Health.Instance.AddExtraHealth();
            rewardButton.interactable = false;
        }
    }
}
