Feature: Player
	In order to play the game
	As an human player 
	I want my player attributes to be correctly represented

Scenario Outline: Health Reduction
	Given I'm a new player
	When I take <damage> damage
	Then My health should now be <expectedHealth>
	Examples: 
	| damage | expectedHealth |
	| 0      | 100            |
	| 40     | 60             |
	| 50     | 50             |


Scenario: Testing Elf race
	Given I'm a new player
		And I am an Elf
	When I take 40 damage
	Then My health should now be 40	

Scenario: Testing Elf race and specific race damage
	Given I'm a new player
		And I have the following attributes
		| attribute | value |
		| Race      | Elf   |
		| Damage    | 10    |




#Scenario: Taking no damage when hit does not affect health
#	When I take 0 damage
#	Then My health should now be 100
#
#Scenario: Starting health is reduced when hit
#	When I take 40 damage
#	Then My health should now be 60
#
#Scenario: Taking too much damage
#	When I take 100 damage
#	Then I should be dead