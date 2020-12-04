# Awful.NET

Awful.NET is a cross-platform browser for the Something Awful forums, based on [Xamarin](https://dotnet.microsoft.com/apps/xamarin) and [.NET](https://dotnet.microsoft.com). It's not a replacement for the existing apps available. Instead, it's a way to experiment with getting Something Awful apps on the broadest range of platforms, all under the same codebase.

![Simulator Screen Shot - iPhone 12 - 2020-12-03 at 19 39 47](https://user-images.githubusercontent.com/898335/101108310-40055f00-35a2-11eb-9382-b2713229a9ad.png)

![Screenshot_20201203-200151](https://user-images.githubusercontent.com/898335/101108484-97a3ca80-35a2-11eb-91b0-68d39becac79.png)

![image0](https://user-images.githubusercontent.com/898335/101108483-970b3400-35a2-11eb-8692-55aef2adcebd.png)

## An Unofficial App

This app is not endorsed by Something Awful.

## Build

Make sure you clone this repository with the submodules (`--recursive`). If you don't, thread tags will not appear in the app. 

Windows

- Download [Visual Studio](https://visualstudio.microsoft.com)
- For Workloads, select:
  - Xamarin
  - .NET Core
- After installing, open `Awful.sln`
- Visual Studio may prompt to install Android SDKs, install them.
- To run the Android build, select `Awful.Mobile.Droid` in the project selection dropdown, and deploy. It should build and deploy to your device or simulator.
- To run the iOS app, you either need to set up a [Xamarin.iOS](https://docs.microsoft.com/en-us/xamarin/ios/get-started/installation/) install on a Mac and sync them together, or set up [Hot Restart](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/deploy-test/hot-restart). This does require installing iTunes, however. Select `Awful.Mobile.iOS` and deploy.

Mac

- Download [Visual Studio](https://visualstudio.microsoft.com)
- For Workloads, make sure iOS, Android, and Mac are checked.
- After installing, open `Awful.sln`
- Visual Studio for Mac may prompt to install Android SDKs, install them.
- To run the Android build, select `Awful.Mobile.Droid` in the project selection dropdown, and deploy. It should build and deploy to your device or simulator.
- To run the iOS app, you need XCode installed. If you don't, you will be prompted to install it. Select `Awful.Mobile.iOS` and deploy.

## Awful.Mobile

Awful.Mobile is the mobile application. We are using Xamarin.Forms and currently targeting iOS and Android. Using Forms, we can make a shared UI that can span multiple platforms with the vast majority of the same code.

## Awful.Core

Awful.Core is the main entry point for interacting with Something Awful. It handles the requests to Something Awful (`AwfulClient` and `Manager`) and parsing the HTML and JSON endpoints to return to the caller (`Handler').

## Awful.Webview

Awful.Webview contains a .NET Standard library for creating new Webviews our of Something Awful assets. The majority of the existing Handlebars templates were based on [Awful.app](https://github.com/Awful/Awful.app). The goal is to overlay their existing templates and Javascript with code that can work cross-platform.

## Awful.Database

Awful.Database is an Entity Framework Core database, using SQlite.

## Awful.Console

Awful.Console is a playground for testing the Awful Managers and web templates. It is useful if you want to test rendering a template or making a backend change in a manager without needing to write a unit test or run the app.

## Awful.Test

Awful.Test are unit tests for the underlying backend libraries. Currently, it targets Awful.Core, Awful.Database, and Awful.UI.
