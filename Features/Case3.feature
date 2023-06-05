Feature: Display greeting message based on the time of day

Scenario: Display correct greeting based on the time of day
    Given I am on the site 
    When I get the current time
    And I set the greeting based on the time of day
    And I click the greeting button
    Then I wait for the greeting message to be displayed
    And the displayed greeting message should be equal to the correct greeting
