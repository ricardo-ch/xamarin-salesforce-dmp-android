# Salesforce DMP SDK for Xamarin

Xamarin.Android binding library for [Salesforce DMP SDK](https://konsole.zendesk.com/hc/en-us/articles/232255108-Android-SDK-Downloads).

For more information on Salesforce DMP SDK see the Android documentation [reference](https://konsole.zendesk.com/hc/en-us/articles/226031268-Android-SDK-Implementation-Guide).

This binding library is available on [Nuget](https://www.nuget.org/packages/Ricardo.Salesforce.DMP.Android/).

## Sample

The SDK require 3 permissions:

``` xml
<uses-permission android:name="android.permission.INTERNET"/>
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION"/>
```

Those permissions have been added in the package and will be automatically set in your manifest on build.

You will also need to manually a service registration in your manifest:

``` xml
<service android:name="com.krux.androidsdk.aggregator.EventPublisherService" android:enabled="true" />
```

If you are using proguard, add those lines:

``` cfg
-dontwarn javax.annotation.**
-dontwarn sun.misc.Unsafe
```

For implementation, see the Ricardo.Salesforce.DMP.Android.Sample project.

## License

- xamarin-salesforce-dmp-android is licensed under [MIT](http://opensource.org/licenses/mit-license)
