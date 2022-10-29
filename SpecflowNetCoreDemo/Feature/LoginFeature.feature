Feature: Login
	Login to EA Demo Application

	#Ensure that the specflow features are indepentant
@smoke
Scenario: Perform Login Of EA Application Site
	Given I launch the application
	And   I click login link
	And  I enter the following details
	       | UserName | Password |
	       | Admin    | password |
	And I click login button
	Then I should see the Employee details link

	
	# so scenarion outline is like a for loop or itrative test run.
	#it iwll run as per the scenarions in the parameters e.g. <url>
	#Scenario Outline: Perform Login Of EA Application Site with <url>
	#Given I launch the application
	#And   I click login link
	#And  I enter the following details
	 #      | UserName | Password |
	 #      | Admin    | password |
	#And I click login button
	#Then I should see the Employee details link

#	Examples: 
#	| url                                  |
#	| http://eaapp.somee.com/Account|
#	| http://eaapp.somee.com/Account/Login |
