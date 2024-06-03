import { Button, Form, Segment } from "semantic-ui-react";
import { GoalSeek } from "../../../../models/goalSeek";
import { ChangeEvent, useState } from "react";

interface Props {
    goalSeek: GoalSeek | undefined;
    create: (goalSeek: any) => void;
}
export default function GoalSeekForm(props: Props) {
    
    const initialState = props.goalSeek ?? {
        input: '',
        multiplier: '',
        maximumIterations: '',
        requiredOutput: ''
    }   

    const [goalSeek, SetGoalSeek] = useState(initialState);

    function handleSubmit() {
       props.create(goalSeek);
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement>) {
        const {name, value} = event.target;
        SetGoalSeek({...goalSeek, [name]: value});
    }
    
    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder = 'Input' value={goalSeek.input} name='input' onChange={handleInputChange} />
                <Form.Input placeholder = 'Multiplier' value={goalSeek.multiplier} name='multiplier' onChange={handleInputChange} />
                <Form.Input placeholder = 'MaximumIterations' value={goalSeek.maximumIterations} name='maximumIterations' onChange={handleInputChange} />
                <Form.Input placeholder = 'RequiredOutput' value={goalSeek.requiredOutput} name='requiredOutput' onChange={handleInputChange}/>
                <Button positive type="submit" content = 'Submit' />
            </Form>
            <Form.Input placeholder = 'Output' value={props.goalSeek} name='Output' />
        </Segment>
    )
}