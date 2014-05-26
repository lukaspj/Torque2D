function Persistence::create(%this)
{
   TamlRead("./objects/Towers.taml");
   TamlRead("./objects/Tiles.taml");
   
   // Load all behavior scripts.  
   exec("./scripts/LevelFillBehavior.cs");
}

//-----------------------------------------------------------------------------

function Persistence::destroy(%this)
{
}