Inventory API that holds, creates, updates and reads inventory Item objects with stat properties.  Cardigan's and shoe

 Account types

 ~Admin
 ~Player

GET items by different criteria 

GET items by random

{
  PlayerId: "PLACEHLOLDER",
  Name: "Placeholder",
  EquippedCardigan:{CardiganId:"PLACEHOLDER", Name:"CARDIGAN_NAME_PLACEHOLDER", Description:"PLACEHOLDER"},
  EquippedShoes:{ShoeId:"PLACEHOLDER", Name:"SHOES_NAME_PLACEHOLDER", Description:"PLACEHOLDER"},
  HandItem: {ItemId:"PLACEHOLDER", Name:"HAND_ITEM_NAME_PLACEHOLDER", Description:"PLACEHOLDER"}
}

-Multiple queries
-Enable CORS
  Allow all origins policy with attributes
-Build player canvas
-be able to play with 2 players




-Possible Token Based Authentication


server sends map and player to client

client paints mapdata and player object
client listens for key press
client sends keypresses to server

server takes keypresses and rund chekc/move commands on player
server sends mapand player to client

client paints madata and player object