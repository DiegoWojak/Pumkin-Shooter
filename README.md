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