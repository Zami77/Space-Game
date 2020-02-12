# Space-Game
This is the outline for the MSSA Space Game project
--------------------------------------------------------------------------------------------
/nCharacter Class
	/nFields: Age = 18, Name, Race (we need to come up races), Currrency, Goal
	/nMethods: Add/Subtract Currency, Get Currency, GetGoal
Ship Class
	Fields: Name, Speed, Gas, GasCapacity, Health, Attack
	Methods: GetCurGas, GetHealth, Add/Subtract Health, GetAttack, Add/Subtract Gas, Travel
Planet Class
	Fields: Name, Distance, Shops, GasPrice
	Methods: GetName
Shop Class
	Fields: Items, Shop Name, Planet Location
	Methods  GetItems, GetGasPrice, RepairShip, 
Item Class
	Fields: Name, Price, Qty
	Methods: GetPrice, Get Qty, GetName
Random Encounter Class
	Fields: Type, Health, Attack, Items
	Methods: GetHealth, Attack, CreateType, SellItems

Planets as 2d array 
	Planets[][] = [a][b][c]
		        [s][d][s]
- For traveling through the planet array, each grid point is one unit of gas.
- Starts at age 18, go until 60 or no currency/health left, run out of gas.
- Each Race has their own end goal
