# HoloLens Experiments
We'll be following the following [tutorial](https://docs.microsoft.com/en-us/windows/mixed-reality/holograms-100) by Microsoft

# Required Software
- Visual Studio Community 2017 (Universal Windows Platform development & Game Development with Unity)
- [HoloLens Emulator](https://go.microsoft.com/fwlink/?linkid=874531) (optional)
- [Unity LTS](https://store.unity.com/download)
- [Vuforia](https://developer.vuforia.com/downloads/sdk) - You can register for a free development license [here](https://developer.vuforia.com/vui/auth/login?url=%2Ftargetmanager%2FlicenseManager%2FsummaryForFreePlan)
- [HoloToolkit](https://github.com/Microsoft/MixedRealityToolkit-Unity/blob/master/GettingStarted.md)

# Work dates
- 12/07 10u30 - 17u -- Installs & Intro, getting familiar with the HoloLens
- 13/07 11u00 - 15u00 -- Gaze + Gestures
- 16/07 10u30 - 16u00 -- reset, spatial mapping 
- 23/07 9u30 - 15u00 -- spatial anchors, first try at placing a logo in a pre-defined position
# FAQ & Issues

#### Remoting to device not working (connection is fine) 
Make sure windows is fully updated (Doesn't work on early windows 10 versions)

#### Build issues (TMPro files missing) 
Make sure you're using the latest LTS version of unity (2017.4)

#### Pairing issues (both Visual Studio and Unity) 
- Be on the same (preferably local) WIFI
- Generate a pairing PIN in HoloLens settings -- visual studio
- Open the HoloLens remote access app (on the lens itself) -- unity
