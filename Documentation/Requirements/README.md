# Requirements
Requirements are defined below and given a priority of must, should or could (the Moscow model).

## User requirements

### Must
* Create new vocabularies. **Done.**
* CRUD operations on vocabularies. **Done.**
* Practice each vocabulary.

### Should
* Option to have multiple translations for a word. One main translation, and more optional translation if user wants to.
* Add information about word class (verb, noun etc).
* Recover vocabularies that were deleted.

### Could
* Restore vocabularies to a state they had at a specific point in time.
* Change language in the application.

## System requirements

### Must
* Store data on the user's computer using XML serialization. **Done.**
* Each word shall have a weight attached to it on a scale 1 - 5 representing how hard it is (1 = easy, 5 = hard). Each word has a weight of 5 when they are first added to a vocabulary. **Done.**
* The weight of the words shall get updated after each practice session. One incorrect answer will increase the weight by one (unless it is currently 5), and two correct answers in a row (could be from different sessions) will reduce the weight by one (unless it is currently 1). **Done.**
* During the practice sessions, the app should generate a weighted random word, which takes into account the weight of each word. **Implemented. Verify with unit test**
* The app shall never generate a word that was asked less than n steps back, where n depends on the number of words in the vocabulary. **Implemented. Verify with unit test**

### Should
* Store multiple translations.
* Store information about word class (verb, noun etc).
* Deleted vocabularyies should be stored away for 30 days before being deleted permanently.
* Recover vocabularies that were deleted no more than 30 days in the past.

### Could
* Store the state of each vocabulary each time it gets updated.
* Remove stored states of vocabularies that are more than 30 days old. 
* Restore vocabularies to a state they had at a specific point in time, but no more than 30 days into the past.
* Change language for the application (english or swedish).