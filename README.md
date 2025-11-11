# in-class-activities-finished
## Devlogs
### W1
Components are the lego pieces, gameobjects are the complete lego buildings, 
and scenes are the towns where I place those buildings.

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1. Becuase r,g,b represents the color values that are between 0~1, which only can be represented with floats.
2. Logically the number ball bounced should be represented in natural number (int)
3. Every line of the code should be end with the semicolon.

### W3

Table Number [1]: The input is a float value which represents the time that player pressed a key, and the output is boolean that tells you whether or not the player accurately hit a beat. 

### W4
Table Number 1.

line 5: _moveSpeed is a memeber variablem and the type is float.
line 22: translation is a local variable and the type is float. It gets the float value from up down inputs, and multiply by _moveSpeed and deltaTime.
lnie 25: the method Translate moves the z value of transform by translation. This method takes x, y, z float values as parameters.

1. I put rigidbody on Cat and SoccerBall because these two are the moving objects, and I checked the IsTriggerOn on Goal because it checks the collision.
2. Everything worked fine.

### W5
Part 1. We know that Transform.position can be set using Vector3, but is it same for Transform.rotation?
==> No, it should be set with Quaternion.Euler(), which takes Vector3 as an input.

Part 2.
Overall plan
1. create target transform variable
2. create a class and add Monobehavior to attach as a component
3. set the target tranfrom to public to assign it from the inspector
4. create private NavMeshAgent and use GetComponent to initiate on Start()
5. call NavMeshAgent.SetDestination() on the target inside of Update() so that user can change the target in game using the inspector


### W6
Part 1. Worked on Unity Engine [link](https://docs.google.com/document/d/1_oQY0junK3b37PITxN8uItEEPKJGHvci47NArvtUxiQ/edit?usp=sharing)

Part 2. 
- attached to all bat
- member variable: 
    - public float speed (set to public to be tunable)
    - private bool isChasing (if is on --> chase / off --> no chase)
- method:
    - public void StopChasing() & StartChasing() --> flip isChasing
    - Update() --> constantly move bat
    

### W7
Part 1. reviewed and added extra info on each section [link](https://docs.google.com/document/d/1RbOJV14KBQmt5sQBiYGuODTakWBMyocLs59OTx8vLRQ/edit?usp=sharing)

Part 2. The original code used Vector3.forward instead of transform.forward, and the difference is that Vector3.forward is not affected by the object's local rotation but has the fixed direction towards global z axis. 

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
