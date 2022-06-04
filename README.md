# Left Field Labs: Unity Engineer Take Home

## Pumpkin Shooter

Currently using Unity 2020.3.0f1

Please see instructions in the file `Left Field Labs Unity Engineer Take Home.pdf`.

## Data I/O:
Added Script:
    name: "DataObject"
    type: ScriptableObject 
    behaviour: abstract
Expect use:
    Extent this object for the necessity of data export/import.

## StartMenu:
## 1:
Added Script:
    name: "MenuData"
    type: ScriptableObject
How to use: 
Can be added at Editor using:
    Assets(left click) -> Create -> MenuData

    ##Save: Select ScriptableObject -> On Inspector click three dots(above open button) -> Save (it will display on console the source).
    ##Load: Select name of the object -> Select ScriptableObject -> On Inspector click three dots(above open button) -> Load.
Additional Information: 
    Edit the camp "name" which is part of the url to create another object or update a curent one,or change it at the source: C:/Users/{YourUser}}/AppData/LocalLow/LeftFieldLabs/Pumpkin Shooter/{_Name}.so
## 2: 
Added Script:
    name: "Constant"
    type: static
How to use:
    For utility 
## 3:
Edited Script:
    name: "MainMenu"
    type: Monobehaviour

#Changes
    Added   UpdateFields Method -> Fields Updated.
            Use MenuData Scriptable to set texts.
            In case not MenuData created and assigned, it will load DefaultData on Run

    Added   UpdateButtonAction Method -> Asssign LoadScene to GameScene


## GameScene:
## 1:
Edited Script:
    name "EnemySpawner"

#Changes
    Added   variables _spamDelay, points;
    Added   Respawn IEnumerator for respawn function
    Added   OnDieCallback for execution Callback.
    Added   GainPoints to increase points for different Pumkin
    Added   HUD references.
Edited Script:
    name "Enemy"
#Changes
    Added   variable Action OnDieCallback for callback and Execution OnDieCallback?.Invoke();


## 2:
    Added Script
        name: "GameSessionData" 
        type: ScriptableObject
    Edited GameSession
    #Changes
        Added Singleton patter to be used with GameSessionData and other variables
        Added method UpdateSpamer for Spammer player
        Added Spammer Data for Utilities
    Added
        Functionalities 
            PlayAgainButton PlayAgain Button
            ReturnToMenuButton Reset Button

## 3 Polish tasks
    Edited Script
        Name: Cannon
        Type: Mono
    #Chanbges
        Added Rotate Towards

