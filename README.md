# Rice Cooker Application

## Overview

This is a simple rice cooker application written in TypeScript. It provides basic functionalities for cooking rice, including monitoring for overheating during the cooking process and ensuring the quality of the rice meets specified criteria.

## Functionalities:

- **Cook Rice (`cuire_riz`):**
  - Initiates the rice cooking process.
  - Monitors for overheating during the cooking process.
  - Ensures the quality of the rice meets specified criteria.
  - Example: `cuiseur.cuire_riz`

- **Keep Warm (`maintien_chaud`):**
  - Maintains the cooked rice warm for a specified duration.
  - Example: `cuiseur.maintien_chaud`

## Linter for TypeScript
https://github.com/hei-school/cc-d4-rice-cooker-ci-MiRandria/blob/feature/typescript/.eslintrc.js 

For linting TypeScript code, you can use a linter such as ESLint. Here's how you can set it up:

1. Install ESLint using npm, the Node.js package manager:

    ```bash
    npm install eslint --save-dev
    ```
2. Run ESLint in the terminal using the following command:

    ```bash
    npx eslint .
    ```

4. Optionally, integrate ESLint into your code editor for real-time feedback.

## Unit Testing in TypeScript

For unit testing in TypeScript, you can use a testing framework like Jest. Here's how you can set it up:

1. Install Jest using npm:

    ```bash
    npm install jest --save-dev
    ```

2. Add a test script to your `package.json` file:

    ```json
    "scripts": {
      "test": "jest"
    }
    ```

3. Run the tests using the following command:

    ```bash
    npm test
    ```

Feel free to adjust these instructions based on your specific project structure and preferences.
