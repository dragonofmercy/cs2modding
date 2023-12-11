## Customize Radios

In the plugin folder you will find a Folder named `Radios`, this is the base folder that create a new Network in the game (just next to "Commercial radios").  
The network name and description can be change using the `meta.json` file inside the `Radios` folder, you can change the SVG file if you want to change the icon.

In the same folder you will find a `Lounge Music` folder, that's a radio sample, you can modifiy it in the same way as the network. This is where you add the various pieces of music you want to listen to.  
**Be careful, the files must be in OGG format**

You can add more Radios if you want, just by create a new folder like `Lounge Music`

### Folder structure

````
├── CustomRadio.dll
├── Radios
│   ├── icon.svg
│   ├── meta.json
│   ├── Lounge Music
│   │   ├── icon.svg
│   │   ├── meta.json
````
## Important Warning

* **Experimental Mod:** Please note that CustomRadio is an experimental mod.

## Feature roadmap

✔️ Loading music files on demand  
✔️ Loading Meta tag from the audio file. (Title, Author, ...)  
✔️ Randomise the clips.  
✔️ Add many Radios as you want

## Thanks

[Cities2Modding](https://github.com/optimus-code/Cities2Modding): An example mod for starting modding in Cities: Skylines II  
[BepInEx](https://github.com/BepInEx/BepInEx): Unity / XNA game patcher and plugin framework  
[Harmony](https://github.com/pardeike/Harmony): A library for patching, replacing and decorating .NET and Mono methods during runtime  
[AlphaGaming7780](https://github.com/AlphaGaming7780): Made the first mod of custom radio where this mod is based on  
