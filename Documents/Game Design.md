# Late-Checkout

## Index
- [Intro](https://github.com/arthurosipyan/Late-Checkout/tree/master#intro)
- [Character Bios](https://github.com/arthurosipyan/Late-Checkout/tree/master#character-bios)
- [Rough Plot](https://github.com/arthurosipyan/Late-Checkout/tree/master#rough-plot)
- [Gameplay Description](https://github.com/arthurosipyan/Late-Checkout/tree/master#gameplay-description)
- [Artistic Style Outline](https://github.com/arthurosipyan/Late-Checkout/tree/master#artistic-style-outline)
- [Systematic Breakdown of Components](https://github.com/arthurosipyan/Late-Checkout/tree/master#systematic-breakdown-of-components)
- [Asset Breakdown](https://github.com/arthurosipyan/Late-Checkout/tree/master#asset-breakdown)
- [Game Flow Diagram](https://github.com/arthurosipyan/Late-Checkout/tree/master#game-flow-diagram)
- [Project Timeline](https://github.com/arthurosipyan/Late-Checkout/tree/master#project-timeline)
- [Additional Ideas and Possibilities](https://github.com/arthurosipyan/Late-Checkout/tree/master#additional-ideas-and-possibilities)

## Intro
You just finished up your business trip and you've found out your flight has been cancelled due to the blizzard, so you're crashing at the motel just a couple miles away. It's not ideal, but it'll have to do. Motels are only creepy in horror movies, right?

## Character Bios
**Jacob Fisher** is a 43-year-old corporate lawyer who's a father of 2. He's eager to get back to his family, after this exhausting business trip. Jacob was hoping to not be assigned to this trip, but got assigned anyway.

## Rough Plot
The game starts off with a cutscene of Jacob Fisher at the airport as he gets notified that his flight has been delayed due to the severe snow storm. Jacob is seen calling his wife and letting her know of the unfortunate news. From there, Jacob transitions from the airport scene to the lobby of the motel, where we see the guy at the front desk hand over the keys to his room. As the cut scene ends, the player takes the key being handed to him and starts to proceed to this room. Along the way, he notices a sinister undertone that the motel is giving off, specifically with the noises being heard from the rooms. Arriving at his room, the player enters and begins to settle in, only he doesn't realize what's in store for the night...

## Gameplay Description
This is an exploration game in a horror setting. The gameplay is centered around the player investigating the motel he's staying at, hoping to find the necessary items to survive the night.

## Artistic Style Outline
UI will be very minimal and simple, nothing fancy. Sound will be a lot like other horror games and movies. The level will look like the typical vacant motel that gives off major creepy vibes. The following are some examples for what the game should aim to look like...

![Cover Art](https://cdn.discordapp.com/attachments/737396307853049916/737689201683857458/image0.jpg)
![Sleep Paralysis Demon](https://cdn.discordapp.com/attachments/737396307853049916/737687850853859398/image0.jpg)
![Motel Hallway](https://cdn.discordapp.com/attachments/737396307853049916/737688662942285944/image0.jpg)

## Systematic Breakdown of Components
3D Renderer, Save/Load System, State Machine, UI System, Sound Effects, and AI.

## Asset Breakdown
### Art Assets:
- **Jacob Fisher** will have a suit with a loose tie, illustrating the typical business man at the end of a long and exhausting day.
- **Enemies** are to be dark and shadowy figures. The fact that the player can't necessarily get a full detailed look at the enemies will play into the unknown aspect for the horror game. A good example would be a sleep paralysis demon that you're not sure is really there until it's too late...
- **The Motel** will be your classic old school motel. The maintenance of the establishment is obviously lacking, as shown by the deteriorating wallpaper and flickering lights. The classic horror movie set at a motel is essentially what we're going for here. The setting is a major component in selling the game's immersion. It will leave the player constantly feeling on-edge and unsafe throughout the game. 
- **UI/Menus** are to be very minimal and dark toned. If there is a theme, it would most likely be related to the old motel wallpaper. It may also include a flickering light when the player hovers over different buttons on the UI/Menu.
- **HUD** won't have much and be minimal as well. The lack of information will contribute to the uneasy environment that Jacob is in.
- **Effects** consist of flickering lights, random sinister noises, objects falling, and doors creaking open. Animations will play a major role in setting up the supernatural occurrences.

### Text Assets:
- There is no tutorial, again leaving the player feeling lost from the very start of the game. The noises and level design will act as a hidden path for where the player should be heading. An example would be the start of the game, where Jacob is in his room and there is only one way in and out: the door. The narration will come from Jacob in the form of random inputs and observations. Text UI is implemented to show what item the player is looking at, as well as if it can be interacted with.

### Sound Assets:
- **In-game Sound** will include the sound of objects falling, creaking floor boards, and sinister ambience for the the background audio.
- **UI/HUD Feedback Sound** will be the sound of an old, flickering florescent light. When the user confirms an option, there will be a sound of a broken light bulb.
- **Music** will only be heard from old radios/record players.
- **Voice** will consist of faint chatter and conversations from afar, as well as Jacob's own narrating voice.

## Game Flow Diagram
### General Game Flow:
`Start -> Menu -> Play -> New Game -> Cutscene -> Level -> Cutscene -> Credits -> End`\
`Start -> Menu -> Play -> Continue -> Load Last Save State -> Credits -> End`\
`Menu -> Settings -> Save & Return`\
`Menu -> Quit -> End`

## Project Timeline
### Prototype
<em>The prototype will aim to have the blackout level, core mechanics, features, and game logic to be fully functional.</em>
- **Milestone 1: Mechanics (8/31/20)**
- **Milestone 2: Game Logic & Features (9/30/20)**

### First Playable
<em>The first playable will build off of the prototype, only this time it will have a good amount of essential assets and level design done.</em>
- **Milestone 3: Level Design & Assets (11/30/20)**

### Vertical Slice
<em>The vertical slice will involve a lot of work towards to the first official trailor of the game.</em>
- **Milestone 4: Alpha (2/28/21)**

### Final Build
<em>The beta will be released and have a limited capacity of players to offically start play testing it.</em>
- **Milestone 5: Beta (5/31/21)**

### Release
<em>The game will be ready for its official release, where all that remains is the marketing behind the game.</em>
- **Milestone 6: Marketing (10/31/21)**

## Additional Ideas and Possibilities
- Player can strategically distract the enemy
