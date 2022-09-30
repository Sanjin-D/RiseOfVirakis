using RiseOfVirakis;

//First time character declaration
Player p_Virakis = new Player(0, 0, "Virakis", 10, 5, 1, 0, 1);
World world = new World();
Items item = new Items();

//
p_Virakis.set_Player_Name("Virakis2nd");
p_Virakis.get_Player_Name();
p_Virakis.get_Player_Position();
p_Virakis.set_Player_Position(10, 10);
p_Virakis.get_Player_Position();
world.getArea(p_Virakis.currentPositionX, p_Virakis.currentPositionY);

world.setWorldSize(500, 500);
world.getArea(p_Virakis.currentPositionX, p_Virakis.currentPositionY);
world.getWorldSize();
p_Virakis.playerMoveForward();
p_Virakis.playerMoveForward();
p_Virakis.playerMoveForward();
p_Virakis.get_Player_Position();
item.writeXML();
p_Virakis.get_Player_Position();





