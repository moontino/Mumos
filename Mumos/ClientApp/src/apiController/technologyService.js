const baseUrl = 'https://localhost:44323/api/home';

export const getAll = async () => {
    const response = await fetch(baseUrl)
    const result = await response.json();
    return result;
};