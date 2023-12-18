import { CuiseurARiz } from './cuiserRice';

describe('CuiseurARiz', () => {
    let cuiseur: CuiseurARiz;

    beforeEach(() => {
        cuiseur = new CuiseurARiz();
    });

    test('cuireRiz should throw an error for low rice quality', () => {
        cuiseur.qualiteDuRiz = jest.fn(() => false);

        expect(() => cuiseur.cuireRiz()).toThrowError('Le riz ne répond pas aux critères de qualité.');
    });

    test('cuireRiz should throw an error for overheat', () => {
        cuiseur.surchauffeDetectee = jest.fn(() => {
            throw new Error('Surchauffe détectée. Arrêt de la cuisson.');
        });

        expect(() => cuiseur.cuireRiz()).toThrowError('Surchauffe détectée. Arrêt de la cuisson.');
    });

    test('maintienChaud should throw an error if no cooking is in progress', () => {
        expect(() => cuiseur.maintienChaud()).toThrowError("Aucune cuisson en cours. Commencez d'abord la cuisson.");
    });

    test('maintienChaud should complete successfully if cooking is in progress', () => {
        cuiseur.cuireRiz();
        expect(() => cuiseur.maintienChaud()).not.toThrow();
    });

    test('surchauffeDetectee should throw an error for overheat', () => {
        cuiseur.surchauffe_temperature = 100; 

        expect(() => cuiseur.surchauffeDetectee()).toThrowError('Surchauffe détectée. Arrêt de la cuisson.');
    });

    test('qualiteDuRiz should return true by default', () => {
        expect(cuiseur.qualiteDuRiz()).toBe(true);
    });
});
