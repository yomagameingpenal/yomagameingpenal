# YOMA GAMING PANEL — Android source project

Purple-neon .NET MAUI app in C# for personal sensitivity notes and a simple drag-shot practice timer. It does not modify Free Fire or include cheats.

## Build from your Android phone using GitHub Actions
1. Download and extract this ZIP.
2. In your phone browser, sign in to GitHub and create a new **public or private repository** named `YomaGamingPanel`.
3. Use GitHub's **Add file → Upload files** page to upload the contents of this folder (including the hidden `.github/workflows/build-android.yml` file). If the mobile page does not show hidden files, use GitHub's web editor to create `.github/workflows/build-android.yml` and paste the workflow contents.
4. Commit the files to the `main` branch.
5. Open the repository's **Actions** tab. If prompted, enable workflows.
6. Select **Build Android APK**, tap **Run workflow**, and wait for it to finish with a green check.
7. Open the successful workflow run, scroll to **Artifacts**, and download `YOMA-Gaming-Panel-APK`.
8. Extract the downloaded artifact ZIP on your phone. Tap the APK to install it. Android may ask you to allow installation from that browser/file manager; only proceed for this APK you built yourself.

## Notes
- This project targets .NET 10 MAUI Android; build availability depends on the GitHub runner and workload support.
- The APK is a test build, not published or security-reviewed.
- Sensitivity numbers are only saved as notes inside this app. They do not apply settings to Free Fire automatically.
