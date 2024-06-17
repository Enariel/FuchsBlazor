import logger from "../utils/logger";

// Exported for js interop
export function toggleAccordionItem(item) {
    const acc = item.closest(".accordion");
    if (!acc) {
        return logger("error", "Accordion not inside '.accordion'");
    }
}