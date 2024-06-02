import { Container, Menu } from "semantic-ui-react";

export default function NavBar() {
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    <h3>DASH coding project</h3>
                </Menu.Item>
            </Container>
        </Menu>
    )
}