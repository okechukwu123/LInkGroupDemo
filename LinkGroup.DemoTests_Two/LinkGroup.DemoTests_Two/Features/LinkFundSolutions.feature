Feature: LinkFundSolutions
	Link Fund Solutions

@mytag
Scenario Outline: Investment Managers
	Given I have opened the Found Soluction page
	When I view Funds
	Then I can select the investment manager for "<Jurisdiction>"Investors
Examples:
	| Jurisdiction |
	| UK           |
	| Irish        | 
	 | Swiss       |  