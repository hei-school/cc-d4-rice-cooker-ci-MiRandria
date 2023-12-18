// .eslintrc.js
module.exports = {
    extends: [
        'eslint:recommended',
        'plugin:@typescript-eslint/recommended',
    ],
    parser: '@typescript-eslint/parser',
    plugins: ['@typescript-eslint'],
    rules: {
      
        '@typescript-eslint/indent': ['error', 4], 
        '@typescript-eslint/explicit-function-return-type': 'off', 
        '@typescript-eslint/no-explicit-any': 'off', 
        '@typescript-eslint/no-unused-vars': ['error', { 'argsIgnorePattern': '^_' }], 
        '@typescript-eslint/no-empty-function': 'off', 
    },
};
  