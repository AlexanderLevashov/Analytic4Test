Feature: AuthorisationUser
	Simple user authorisation

@mytag
Scenario: Perform user authorisation. Logout and login as guest.
	Given The authorisation page is given
	When Enter the data for user authorisation, logIn and logOut of account
	Then LogIn from as guest