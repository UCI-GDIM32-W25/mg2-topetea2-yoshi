[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
Write your Devlog here!

My original MG2 plan outlined four core system: grounded jumping, infinite gameplay, random coin spawning, and a score system. Each part of that plan ended up mapping directly into specific scripts and GameObjects in the Unity scene. For instance, the Pengunin GameObject uses a Rigidbody, a CapsuleCollider2D, and my GameController script, where the Update() method checks for the Space key and applies jump force only when the penguin is grounded. nfinite gameplay came from attaching "ScrollingPlatform" to the Floor and CameraFollow to the Main Camera, which matched my plan to keep the world moving while the player stayed centered. My idea for the coin collectables became the biggest problem at of this entire minigame, but I was able to resolve it by creating a prefab for the coin and put SpawnCoins() inside the CoinSpawner script on the CoinSpawner GameObject, where Random.Range(minTime, maxTime) controls the timing of each Instantiate(CoinPrefab) call. 


The biggest shift from my original plan happened when I realized how important prefabs are for spawning. At first, I dragged a scene coin into the spawner instead of the prefab, which caused only one coin to appear. After reviewing the professor's example and debugging my own setup, I updated my plan so that all spawned objects come from prefabs stored in the project panel. Once I attached Coin.cs to the Coins prefab and used OnTriggerEnter2D(), to call ScoreManager.instance.AddPoint() and Destroy(gameObject), the scoring system worked exactly as planned. Overall, the final game follows the structure of my initial breakdown, but the debugging process taught me why Unity seperated scene objects from prefabs and how each script fits into the larger system. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
