using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class UIReklamScripts : MonoBehaviour
{
    private BannerView reklamObjesi;

    void Start()
    {
        MobileAds.Initialize(reklamDurumu => { });
        AdSize adsize = new AdSize(320, 50);

        reklamObjesi = new BannerView("ca-app-pub-1882617355552623/9208277234", adsize, AdPosition.Bottom); // Test Reklam İd "ca-app-pub-3940256099942544/6300978111"
        AdRequest reklamIstegi = new AdRequest.Builder().TagForChildDirectedTreatment(true).Build();
        reklamObjesi.LoadAd(reklamIstegi);
    }

    void OnDestroy()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
