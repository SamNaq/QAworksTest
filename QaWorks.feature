Feature: QaWorks
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@QaTest
@broswser: Chrome
Scenario: User can navigate to contact Us page
	Given I navigate to the web page "http://www.qaworks.com/"
	Then I click on contact us page
	And I submit the get in touch form

	