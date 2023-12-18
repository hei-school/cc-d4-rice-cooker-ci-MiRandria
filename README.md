# Rice Cooker Application

## Overview

This is a simple rice cooker application written in Ruby. It provides basic functionalities for cooking rice, including monitoring for overheating during the cooking process and ensuring the quality of the rice meets specified criteria.

## Functionalities:

- **Cook Rice (`cuire_riz`):**
  - Initiates the rice cooking process.
  - Monitors for overheating during the cooking process.
  - Ensures the quality of the rice meets specified criteria.
  - Example: `cuiseur.cuire_riz`

- **Keep Warm (`maintien_chaud`):**
  - Maintains the cooked rice warm for a specified duration.
  - Example: `cuiseur.maintien_chaud`

## Linter for Ruby
https://github.com/hei-school/cc-d4-rice-cooker-ci-MiRandria/blob/feature/ruby/Gemfile

For linting Ruby code, you can use a linter such as RuboCop. Here's how you can set it up:

1. Install RuboCop using gem, the Ruby package manager:

    ```bash
    gem install rubocop
    ```

2. Create a `.rubocop.yml` file at the root of your project with your preferred settings. Here's an example:

    ```yaml
    AllCops:
      TargetRubyVersion: 2.7
    ```

3. Run RuboCop in the terminal using the following command:

    ```bash
    rubocop .
    ```

4. Optionally, integrate RuboCop into your code editor for real-time feedback.

## Unit Testing in Ruby

For unit testing in Ruby, you can use a testing framework like RSpec. Here's how you can set it up:

1. Install RSpec using gem:

    ```bash
    gem install rspec
    ```

2. Run the tests using the following command:

    ```bash
    rspec
    ```

Feel free to adjust these instructions based on your specific project structure and preferences.
