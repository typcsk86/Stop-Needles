using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine.SceneManagement;

public class WonKontrolcusu : MonoBehaviour
{
    private InterstitialAd interstitial;

    public Animator wonAnimasyonu;

    private int rightKonrol;
    private int leftKontrol;
    private int upKontrol;
    private int rightTopKontrol;
    private int leftTopKontrol;

    public int buildIndex = 0;

    void Awake()
    {
        wonAnimasyonu.SetBool("BitisWon", false);

        PlayerPrefs.DeleteKey("rightNeedleBitisKontrolcusu"); 
        PlayerPrefs.DeleteKey("leftNeedleBitisKontrolcusu");
        PlayerPrefs.DeleteKey("upNeedleBitisKontrolcusu");
        PlayerPrefs.DeleteKey("rightTopNeedleBitisKontrolcusu");
        PlayerPrefs.DeleteKey("leftTopNeedleBitisKontrolcusu");

    }

    // Start is called before the first frame update
    void Start()
    {
        wonAnimasyonu.SetBool("BitisWon", false);
        this.RequestInterstitial();

        buildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        rightKonrol = PlayerPrefs.GetInt("rightNeedleBitisKontrolcusu");
        leftKontrol = PlayerPrefs.GetInt("leftNeedleBitisKontrolcusu");
        upKontrol = PlayerPrefs.GetInt("upNeedleBitisKontrolcusu");
        rightTopKontrol = PlayerPrefs.GetInt("rightTopNeedleBitisKontrolcusu");
        leftTopKontrol = PlayerPrefs.GetInt("leftTopNeedleBitisKontrolcusu");

        if(rightKonrol == 1 && leftKontrol == 1 && upKontrol == 1 && rightTopKontrol == 1 && leftTopKontrol == 1)
        {

            if(buildIndex % 2 == 0)
            {
                this.GameOver();
            }

            int saveIndex = PlayerPrefs.GetInt("saveIndex");

            if (buildIndex > saveIndex)
            {
                PlayerPrefs.SetInt("saveIndex", buildIndex);
            }

            wonAnimasyonu.SetBool("BitisWon", true);
        }
    }
    
    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1882617355552623/5133107335";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().TagForChildDirectedTreatment(true).Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void GameOver()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }

    public void destroyInterstitial()
    {
        this.interstitial.Destroy();
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
}
