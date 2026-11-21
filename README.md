# MG7
## Devlog
Regarding the usage of Array, since Bird is a Class, I directly use Bird[] to create an Array and store all the bird components in the variable _birds. Then, I call this Array within a for loop, starting from 0 to iterate until the length of the entire Array. This way, we can check each bird one by one. About the usage of Vector, I used Vector3.Distance() to calculate the distance between the bird and the player. By comparing this distance with _interactDistance, the code can determine whether the player is close enough to the bird. If the distance is less than or equal to the set range, we will use SetActive(true) to activate the corresponding bird and make it pop out from the tree.
## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
