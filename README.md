# The Hibernation database

## What it is
This is a C#/.NET frontend application to go with [this backend](https://github.com/JafethvE/ExilianWinterCreativeCompetition2023).
It offers a simple GUI to view and modify the entries in the backend's database.

## How it works
This application uses the backend's REST interface to view, modify, and/or delete database entries.

## Running it

### During the contest
For the duration of the contest I will be hosting an instance of the backend myself.
Therefore you will only need this programme to try it out.

To run you can download the release from [dropbox](https://www.dropbox.com/scl/fo/bw1pov9fgrnqv9vsq5myh/h?rlkey=jzclb65byxowpzqwvvvvpb0wu&dl=0).
Download and extract this entire folder and run the ExilianWinterCreativeCompetition2023.Frontend.exe

### After the contest
If you want to run this programme after the contest you will have to host an instance of the backend yourself.
Instructions for that can be found on [the backend page](https://github.com/JafethvE/ExilianWinterCreativeCompetition2023)

When you run it locally you will have to modify the Settings.ini file that comes with the release package:

1. For the option 'url' you fill in 'localhost'
2. For the option 'port' you fill in the port as you set it in the backend deployment.yaml (default 1001)

You will now be connected to your local instance.