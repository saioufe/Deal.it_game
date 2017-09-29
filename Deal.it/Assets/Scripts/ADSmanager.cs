using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class ADSmanager : MonoBehaviour, IRewardedVideoAdListener {
    public Text testADS;
    private bool IsThereAnVideo;
    // Use this for initialization
    void Start () {
        string appKey = "0cbff1b79df887969f10a51672edc64514dac25b2c1c9cb0";
        //Appodeal.disableLocationPermissionCheck ();
        Appodeal.setTesting(false);
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO);
        Appodeal.setRewardedVideoCallbacks(this);
    }
	
	// Update is called once per frame
	void Update () {
        testADS.text = IsThereAnVideo.ToString();

        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            IsThereAnVideo = true;

        }
        else
        {
            IsThereAnVideo = false;

        }
    }


    public void onInterstitialLoaded() { print("Interstitial loaded"); }
    public void onInterstitialFailedToLoad() { print("Interstitial failed"); }
    public void onInterstitialShown() { print("Interstitial opened"); }
    public void onInterstitialClosed()
    {
        
    }
    public void onInterstitialClicked()
    {

    }

    public void ShowRewareded()
    {

        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
        }

    }
    public void onRewardedVideoLoaded()
    {
    }
    public void onRewardedVideoFailedToLoad()
    {

    }
    public void onRewardedVideoShown()
    {
    }
    public void onRewardedVideoClosed()
    {
    }
    public void onRewardedVideoFinished(int amount, string name)
    {
      
    }
}
