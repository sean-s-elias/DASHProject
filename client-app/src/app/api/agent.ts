//Centralized location for all API requests
import axios, { AxiosResponse } from 'axios';
import { GoalSeek } from '../models/goalSeek';

axios.defaults.baseURL = 'http://localhost:5000/api';

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
    post: (url: string, body: {}) => axios.post(url, body).then(responseBody)
}

const GoalSeekCalculation = {
    create:  (goalSeek: GoalSeek) => axios.post('/goalseek', goalSeek)
}

const agent = {
    GoalSeekCalculation
}

export default agent;