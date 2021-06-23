![Voidwyrm](https://media.discordapp.net/attachments/857116536098521098/857266522262863923/960px.png?width=100&height=100)
# Voidwyrm API
![Voidwyrm](https://img.shields.io/badge/Core-v2.0-blue?style=for-the-badge)
![Voidwyrm](https://img.shields.io/badge/Voidwyrm-v2.0-blue?style=for-the-badge)
![Voidwyrm](https://img.shields.io/badge/Hooked%20Events-∞-cyan?style=for-the-badge)
![Voidwyrm](https://img.shields.io/badge/Build-Pre%20Release-cyan?style=for-the-badge)



Voidwyrm Core is a REST API handler for the mod Voidwyrm for ARK: Survival Evolved. It works simillar to ARK Server API but differs due to it not requiring executables to be run inside the Server iteself and can be hosted remotely. Voidwyrm Core Includes plugins and libraries which makes it easy to develop for, called Cogs! 

This project uses C# as a base but can be expanded to many more prorgamming languages due to its structure and complexity.

# Cogs
Cogs are plugins used by Voidwyrm API to Bind to Certain events in game and cast them to a new function within your Cog! Cogs are still experimental and should not be used on production servers! 

Example : 
```
cogs/
    $CogName1/
        $CogName1.dll
        (additional files)
    $CogName2/
        $CognName2.dll
```

# CogModding
Not available right now.

# SuchSpeed
Not available right now.

# Limitations
Voidwyrm Core is using HTTP2 Request Handlers which are Asynced which makes them faster than a normal request but this is not meant to be a replacement for ARK Server API but rather a alternative to which is safer, faster, more dynamic and customizable and easy to understand with our wiki page, forums and documentation!

# About
This project was created in collaboration with **Bloody ARK**, big thanks to Sly and the rest of the team!
![BloodyARK](https://preview.redd.it/k1lgntbte8b31.png?width=400&format=png&auto=webp&s=c35c9e644d5be30ba2747dc40b4b540727f95868)
