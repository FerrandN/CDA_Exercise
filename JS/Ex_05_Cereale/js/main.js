import { Cereals } from "./cereals.js";
import {TableGenerator} from "./tableGenerator.js"

let cereals = new Cereals();
await cereals.getCereals();

let cerealTable = new TableGenerator(cereals);
cerealTable.generateHeader();
cerealTable.generateBody();
cerealTable.generateFooter();