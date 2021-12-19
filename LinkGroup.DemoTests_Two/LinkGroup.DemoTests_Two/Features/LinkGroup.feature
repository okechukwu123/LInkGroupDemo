Feature: LinkGroup

Background: Home page	

@mytag
Scenario: Smoke test
When I open the home page
Then the page is displayed

@mytag
Scenario: Contact page
When I open the home page
And I have agreed to the cookie policy
When I select Contact
Then the Contact page is displayed