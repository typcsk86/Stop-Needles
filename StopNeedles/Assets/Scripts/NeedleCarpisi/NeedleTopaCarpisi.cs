using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine.SceneManagement;

public class NeedleTopaCarpisi : MonoBehaviour
{
    public Animator loseAnimasyonu;

    public Text loseCevirici;

    public Button NextLevelButonKapatici;

    private InterstitialAd interstitial;

    public int loseBuildIndex = 0;

    private int rastgeleReklamCikisSayisi;

    // Start is called before the first frame update
    void Start()
    {
        loseAnimasyonu.SetBool("BitisWon", false);

        this.RequestInterstitial();

        loseBuildIndex = SceneManager.GetActiveScene().buildIndex;

        rastgeleReklamCikisSayisi = UnityEngine.Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            if (loseBuildIndex % 2 != 0)
            {
                if(rastgeleReklamCikisSayisi == 1)
                {
                    this.GameOver();
                }
            }

            loseAnimasyonu.SetBool("BitisWon", true);

            loseCevirici.text = "You Lose";
            NextLevelButonKapatici.interactable = false;
        }
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1882617355552623/4277538274";
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
