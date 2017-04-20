# More documentation about how to customize your build
# can be found here:
# https://docs.fastlane.tools
fastlane_version "1.109.0"

# This value helps us track success metrics for Fastfiles
# we automatically generate. Feel free to remove this line
# once you get things running smoothly!
generated_fastfile_id "ca8a7b4c-ab8c-4490-bae3-5e2fb3a26329"

default_platform :ios

# Fastfile actions accept additional configuration, but
# don't worry, fastlane will prompt you for required
# info which you can add here later
lane :beta do
  # build your iOS app
  gym(
    # scheme: "YourScheme",
    export_method: "ad-hoc"
  )

  # upload to HockeyApp
  hockey(
    # api_token: "YOUR_API_TOKEN"
  )

  # slack(
  #   slack_url: "https://hooks.slack.com/services/IDS"
  # )
end
