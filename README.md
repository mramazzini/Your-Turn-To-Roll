# Game Planning Document - Your Turn to Roll

## 1. Overview

- **Game Title:** Your turn to roll
- **Genre:** Roguelike RPG
- **Core Concept:** A turn based roguelike RPG where you take four adventurers you control through a campaign to defeat the boss at the end, leveling up and upgrading your characters along the way.
- **Target Audience:** Fans of turn based RPGs and roguelikes and DND players.
- **Unique Selling Points (USPs):** The game has a unique roguelike system where you can level your dice and characters up to make them stronger. It is heavily inspired by DND and has a lot of the same mechanics, which will make it appealing to fans of the game.
- **Inspirations:** DND, Balatro, Risk of Rain 2, Hades

---

## 2. Gameplay Mechanics

### 2.1 Core Loop

- **Start:**
  - The player must select a campaign to play through. Each campaign has different enemies, bosses, encounters and loot. Ex. The player could choose to play through the campaign of the Lich King, where they must defeat the Lich King at the end, fighting a lot of undead along the way.
  - The player must select a dice set to play the game with. Each dice set has a d4, d6, d8, d10, d12, and d20. The dice set they choose will provide different buffs/abilities to their run. Ex. If they choose the 'Crit' dice set, they can crit on a 19 or 20.
  - After selecting a campaign and dice set, the player will be taken to the first level of the campaign. They will be given 4 adventurers to control, these will each have a random class and background.
- **Exploration:** The main gameplay loop will surround "encounters". These encounters represent a single area the player can go. When they defeat an encounter, they can choose from a randomly generated list of encounters to go to next. Each encounter will have a different set of enemies, loot, and events. After players defeat enough encounters, they reach the end of a story arc, which will have a boss encounter for them to fight.
- **Adventurers** Adventurers have a class, background, species, stats and subclass.

  - **Class:** The class of the adventurer will determine what features they have. Ex. A wizard will have magic abilities, a fighter will have melee abilities, etc. As you level up, you gain more features from your class.
  - **Background:** The background of a character will determine their starting proficiencies, as well as some starter items.
  - **Species:** The species of a character will determine their starting stats and abilities. Ex. A dragonborn will have a breath weapon, a tiefling will have fire resistance, etc.
  - **Stats:** The stats of a character will determine how good they are at certain things. The stats match DND, with STR, DEX, CON, INT, WIS, and CHA. They have the following benefits:

    - **STR:** Determines how much damage you do with melee attacks.
    - **DEX:** Determines how much damage you do with ranged attacks, as well as your AC.
    - **CON:** Determines how much health you have.
    - **INT:** Spellcasting ability for certain classes.
    - **WIS:** Spellcasting ability for certain classes.
    - **CHA:** Spellcasting ability for certain classes.
    - **Skills:** Each character will have a set of skills they can use. Each skill is based of its corresponding stat. Ex. A character with high STR will have a high Atheletics skill. Skills can be used throughout the game to do things like persuade NPCs, pick locks, avoid encounters, etc. Each encounter will have a skill check associated with it. You can choose an Adventurer to handle it, risking them, but also allowing the one with the highest chance of success. Here are the skills:
      - **Acrobatics (DEX):** Used to avoid traps, dodge attacks, etc.
      - **Animal Handling (WIS):** Used to calm animals, etc.
      - **Arcana (INT):** Used to identify magic items, etc.
      - **Athletics (STR):** Used to climb, jump, etc.
      - **Deception (CHA):** Used to lie, etc.
      - **History (INT):** Used to recall historical events, etc.
      - **Insight (WIS):** Used to determine if someone is lying, etc.
      - **Intimidation (CHA):** Used to intimidate people, etc.
      - **Investigation (INT):** Used to find hidden things, etc.
      - **Medicine (WIS):** Used to heal people, etc.
      - **Nature (INT):** Used to identify plants, etc.
      - **Perception (WIS):** Used to notice things, etc.
      - **Performance (CHA):** Used to perform
      - **Persuasion (CHA):** Used to persuade people, etc.
      - **Religion (INT):** Used to identify religious symbols, etc.
      - **Sleight of Hand (DEX):** Used to pickpocket, etc.
      - **Stealth (DEX):** Used to hide, etc.
      - **Survival (WIS):** Used to survive in the wild, etc.
    - **Combat System:** The combat system will be turned based, and heavily inspired by DND. Every enemy and character will roll initiative (1d20 + DEX), and the order of combat will be determined by the initiative rolls. Each character will have a set of abilities they can use. Combat resources are defined by an action, bonus action, reaction, and movement. You can gain more resources by purchasing upgrades/items or getting features that grant you more resources. Once one side has run out of HP, the combat is over.
    - **Progression:** After each encounter, the players will gain xp to level up their characters. This will grant them class features, which grants them more special abilities. These abilities are meant to synergize with other classes/items, to ramp up the scaling of the game.
    - **Game Over & Replayability:** If all of your characters die in an encounter, it is game over. You can now start a new campaign with new characters. You can also unlock dice sets, classes, backgrounds, species, and subclasses, by completing certain achievements in the game. This will give you more options to play with in future runs. You can also unlock new campaigns by completing certain achievements in the game. This will give you more content to play through in future runs. After you win a campaign, you can play that same campaign again, but with a higher difficulty. This will give you more of a challenge, to keep the game interesting.
    - **Victory Condition:** However, if you defeat a certain number of story arcs, "say 5", you have won enough encounters to have "won" the campaign. This will unlock a new campaign for you to play through, with new enemies, bosses, encounters, and loot.

    ### 2.2 Player Abilities & Actions

    - **Movement & Controls:** A grid based 2d map where you can move your characters around. You can move your characters to different squares on the grid, and interact with objects in the environment.
    - **Attacks & Skills:** Each character will have a set of abilities they can use. These abilities will be based off of their class and subclass. Ex. A wizard will have spells, a fighter will have melee abilities, etc.
    - **Defensive Mechanics:** Each character will have an AC, which will determine how hard they are to hit. They can also have abilities and items that allow them to dodge attacks, or take less damage from attacks.

    ### 2.3 Procedural Generation

    - **Encounter Layout:** Each encounter will have a different layout, with different enemies, loot, and events. The layout will be randomly generated with unique tiles, enemies, and loot.
    - **Enemy & Item Placement:** Enemies and loot will be placed randomly throughout the encounter. The player will have to explore the encounter to find all of the enemies and loot.
    - **Environmental Hazards:** Each encounter will have different environmental hazards that the player will have to avoid. Ex. Traps, lava, poison, etc. Skill checks can be used to avoid these hazards/disarm them/spot them.

    ***

## 3. Meta-Progression & Upgrades

### 3.1 Character Progression

- **Permanent Unlocks:** (Classes, backgrounds, species, subclasses)
- **Temporary Buffs:** (Potions, scrolls, consumables, items)
- **Character Builds:** (Synergies, min-maxing)

### 3.2 Items & Equipment

- **Weapons:** You can find items and weapons throughout the game that will give you different abilities. Ex. A sword that gives you +1 to hit, a staff that gives you +1 to spellcasting, etc.
- **Consumables:** You can find consumables throughout the game that will give you different abilities. Ex. A potion that heals you, a scroll that gives you a spell, etc.
- **Relics/Artifacts:** After defeating a boss, you can find a relic/artifact that will give you a permanent buff. Ex. A relic that gives you +1 to hit, an artifact that gives you +1 to spellcasting, etc.
- **Currencies:** Gold can be acquired throughout the game, which can be used to purchase items, weapons, consumables, and relics/artifacts.

### 3.3 Economy & Shops

- **Vendors:** Certain encounters will have vendors that you can buy items from. These items will be randomly generated, and will cost gold to purchase.
- **Item Rarity System:** Items will have different rarities, which will determine how good they are. Ex. Common, Uncommon, Rare, Epic, Legendary.

---

## 4. Enemies & AI

- **Enemy Types:** Enemies will be generated and inspired from the DND Srd. Ex. Skeletons, goblins, orcs, etc. Each enemy will have different abilities and stats.
- **AI Behavior:** Enemies will have different AI behaviors, which will determine how they act in combat. Ex. A goblin will try to run away if it is low on health, a skeleton will try to attack you
- **Difficulty Scaling:** Difficulty will be represented by CR, which will determine how hard the encounter is. Ex. A CR 1 encounter will be easy, a CR 5 encounter will be hard, etc.
- **Boss Encounters:** After defeating enough encounters, you will reach the end of a story arc, which will have a boss encounter for you to fight. Bosses will have different unique abilities and stats, which will make them harder to defeat than normal enemies. They will be designed to shut down certain strategies, and force you to adapt to their playstyle.

---

## 5. Art & Visual Style

- **Overall Aesthetic:** 2d, snappy and quick animations, pixel art
- **Character Design:** Tokens for the characters
- **Environmental Design:** Tiles for the environment, which will be randomly generated

---

## 6. Sound & Music

- **Sound Effects:** (Combat, interactions, UI feedback)
- **Music:** (Dynamic? Adaptive? Chiptune? Orchestral?)
- **Voice Acting:** (Yes/No, minimal grunts, full dialogues?)

---

## 7. Narrative & World-Building

- **Story Premise:** (Does the game have a narrative? Lore?)
- **Characters & Factions:** (Who are the major players?)
- **Dialogue System:** (Linear, branching, silent protagonist?)
- **World & Setting:** (Fantasy, sci-fi, cyberpunk, dark souls-like?)

---

## 8. Technical Aspects

### 8.1 Engine & Tools

- **Game Engine:** (Unity, Godot, Unreal, custom?)
- **Procedural Generation Framework:** (Custom algorithm, perlin noise, etc.)
- **Networking:** (Is it multiplayer? Online leaderboards?)
- **Save System:** (Cloud saves? Local persistence?)

### 8.2 Performance & Optimization

- **Target FPS & Platforms:** (PC, console, mobile?)
- **Memory & Load Times:** (How to optimize assets?)
- **Rendering & Asset Streaming:** (How are levels loaded?)

---

## 9. Monetization & Business Model

- **Pricing Model:** (Premium, free-to-play, subscription?)
- **DLC & Expansions:** (Post-launch content plans?)
- **Cosmetics & Unlockables:** (Purely cosmetic or gameplay-affecting?)
- **Marketing Strategy:** (How will the game be promoted?)

---

## 10. Roadmap & Development Timeline

- **Phase 1 - Prototype:** (Basic movement, procedural gen, combat prototype)
- **Phase 2 - Alpha:** (Core systems, basic enemies, minimal UI)
- **Phase 3 - Beta:** (More levels, balancing, polish, first testers)
- **Phase 4 - Release Candidate:** (Bug fixing, marketing push)
- **Phase 5 - Post-Launch Support:** (Updates, patches, community feedback)

---

## 11. Risks & Challenges

- **Technical Challenges:** (What could slow down development?)
- **Scope Creep:** (How to avoid over-expansion?)
- **Market Competition:** (How does the game stand out?)
- **Playtesting & Feedback:** (How to gather and implement player feedback?)
